using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBprogram.DB
{
    public class DB
    {
        public enum Table
        {
            bas,
            edu,
            marriage,
            work
        }
        public enum Type
        {
            id,
            name,age,sex,
            school_name,background,
            married,
            department,position,title,wage,bonus,join_time,work_status
        }
        //Server=.;DataBase=DBprogram;uid=baiwangchang;pwd=ABCCBA131uB
        private static String connsql = "Server=localhost\\MSSQLSERVER01;Database=DBprogram;Trusted_Connection=True";
        private static SqlConnection conn = new SqlConnection();
        // 数据库连接字符串,database设置为自己的数据库名，以Windows身份验证
        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public static bool Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {

                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接
                }
                catch
                {
                    return false;
                }

                return true;

            }
            else return true;
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public static void Close()
        {
            conn.Close();
        }

        public static bool Load(string id, string psw)
        {
            string temp_PSW = "";
            string cmd = "select PWD from Account where Id = '" + id + "'";

            SqlCommand command = new SqlCommand(cmd, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds, "User");
            try
            {
                temp_PSW = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                return false;
            }
            if (temp_PSW.Equals(psw))
                return true;
            else return false;
        }
        public static bool Regiest(string id, string psw, string email)
        {
            string cmd = "insert into Account values('" + id + "','" + psw + "','" + email + "')";

            try
            {
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static DataSet Getmail()
        {
            string search = "select Email from Account";

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds);

            return ds;
        }
        public static string GetUserNum()
        {
            string id = "";
            string search = "select * from Account";

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds);

            id = ds.Tables[0].Rows.Count.ToString("0000000000");

            return id;
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public static DataSet GetData()
        {
            string search = "select work.*,base.age,base.name,base.sex,edu.background,edu.school_name,marriage.married from base,edu,marriage,work where base.work_id = edu.work_id and edu.work_id = marriage.work_id and marriage.work_id = work.work_id";

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds, "employee");

            return ds;
        }
        /// <summary>
        /// 获取离职成员
        /// </summary>
        /// <returns></returns>
        public static DataSet GetLeave()
        {
            string search = "select work.*,base.age,base.name,base.sex,edu.background,edu.school_name,marriage.married,rea.reason from base,edu,marriage,work,rea where rea.work_id = base.work_id and base.work_id = edu.work_id and edu.work_id = marriage.work_id and marriage.work_id = work.work_id and work_status = 'False'";

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds, "employee");

            return ds;
        }
        /// <summary>
        /// 获取在职成员
        /// </summary>
        /// <returns></returns>
        public static DataSet GetActivity()
        {
            string search = "select work.*,base.age,base.name,base.sex,edu.background,edu.school_name,marriage.married from base,edu,marriage,work where base.work_id = edu.work_id and edu.work_id = marriage.work_id and marriage.work_id = work.work_id and work_status = 'True'";

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds, "employee");

            return ds;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="upvalue">更新的数据的值</param>
        /// <param name="work_id">被更新的人员的工号</param>
        /// <param name="key">更新的列</param>
        /// <returns></returns>
        public static bool UpdateData(string upvalue, string work_id, string key)
        {
            string table = "";
            for (Type i = Type.id; i <= Type.work_status; ++i)
            {
                if (Enum.GetName(typeof(Type), i) == key)//获取修改的关键字的类型
                {
                    if (i > Type.married)
                        table = "work";
                    else if (i > Type.background)
                        table = "marriage";
                    else if (i > Type.sex)
                        table = "edu";
                    else table = "base";
                    break;
                }
            }
            string search = "update " + table + " set " + key + "='" + upvalue + "' where work_id ='" + work_id + "'";
            try
            {
                SqlCommand command = new SqlCommand(search, conn);
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool ChangeStatus(string work_id, string reason)
        {
            string search = "insert into rea values('" + work_id + "','" + reason + "')";

            SqlCommand command = new SqlCommand(search, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool ChangeStatus(string work_id)
        {
            string search = "delete from rea where work_id='" + work_id + "'";

            SqlCommand command = new SqlCommand(search, conn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool AddMember(string[] str_info)
        {
            int i = 0;
            string[] insert = { "insert into base values ('" + str_info[i++] + "','" + str_info[i++] + "'," + str_info[i++] + ",'" + str_info[i++] + "')",
                                "insert into edu values ('"+str_info[0]+"','"+str_info[i++]+"','"+str_info[i++]+"')",
                                "insert into marriage values ('"+str_info[0]+"','"+str_info[i++]+"')",
                                "insert into work values ('"+str_info[0] + "','" + str_info[i++] + "','" + str_info[i++] + "','" + str_info[i++] + "'," + str_info[i++] + "," + str_info[i++]+",'"+System.DateTime.Now.ToString()+"','"+str_info[i]+"')"};
            foreach(string str in insert)
            {
                try
                {
                    SqlCommand command = new SqlCommand(str, conn);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 搜索一张表的信息
        /// </summary>
        /// <param name="table">表名</param>
        public DataSet Search(Table tab)
        {
            string table = Enum.GetName(typeof(Table), tab);

            if (table == "bas")
                table = "base";

            string search = "select * from " + table;

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds, "employee");

            return ds;
        }
        /// <summary>
        /// 模糊查询 根据某一关键字获取信息
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public DataSet Search(Type type, string keyword)
        {
            DataSet ds = new DataSet();

            if (conn.State == ConnectionState.Open)
            {
                string table = "";
                string strType = "";
                if (type > Type.married)
                    table = "work";
                else if (type > Type.background)
                    table = "marriage";
                else if (type > Type.sex)
                    table = "edu";
                else table = "base";

                strType = Enum.GetName(typeof(Type), type);

                string search = "select work.*,base.age,base.name,base.sex,edu.background,edu.school_name,marriage.married from base,edu,marriage,work where " +
                    table + "." + strType + "= %" + keyword + "% and base.work_id = edu.work_id and edu.work_id = marriage.work_id and marriage.work_id = work.work_id";

                SqlCommand command = new SqlCommand(search, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(ds, "employee");
            }
            return ds;
        }
        public static string Find(string id, string email)
        {
            string search = "select PWD from Account where Id='" + id + "'and Email='" + email + "'";

            SqlCommand command = new SqlCommand(search, conn);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(ds);
            string i = ds.Tables[0].Rows[0][0].ToString();
            return i;
        }
        
    }
}
