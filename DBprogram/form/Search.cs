using DBprogram.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DBprogram
{

    public partial class Search : Form
    {
        private string seach_text = "";
        private int last_i;
        private string frevalue = "";//改变之前的值
        private string value = "";//改变之后的值

        public delegate void childclose();
        public event childclose Closefather;
        public delegate void Return();
        public event Return Returnfather;

        public Search()
        {
            InitializeComponent();

            comboBox.SelectedIndex = 0;

            sea_text.AutoSize = false;
            sea_text.Height = 35;
            

            DB.DB.Open();
            
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns[0].ReadOnly = true;
            this.dataGridView.DataSource = DB.DB.GetData();
            this.dataGridView.DataMember = "employee";

            DB.DB.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Closefather();
            }
            catch (Exception)
            {
                MessageBox.Show("出现异常", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void return_Panel_Click(object sender, EventArgs e)
        {
            try
            {
                Returnfather();
                Close();
            }
            catch
            {
                MessageBox.Show("出现异常", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 改变窗体大小时，各控件的位置变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Resize(object sender, EventArgs e)
        {
            Point exit = new Point(this.Width - 180, 10);
            Point ret = new Point(this.Width - 340, 10);
            Point sea = new Point(420, 10);
            Point sea_t = new Point(150, 10);
            Point comb = new Point(10, 10);
            exitButton.Location = exit;
            return_Panel.Location = ret;
            dataGridView.Height = this.Height - 110;
            dataGridView.Width = this.Width;
            seach_button.Location = sea;
            sea_text.Location = sea_t;
            comboBox.Location = comb;
            button1.Location = new Point(this.Width - 440, 10);
        }
        /// <summary>
        /// 点击查询按钮后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seach_button_Click(object sender, EventArgs e)
        {
            int row = dataGridView.Rows.Count - 1;//得到总行数
            int i, j = comboBox.SelectedIndex;
            bool flag = true,//用于记录更新的位置
                flag2 = false;//用于记录是否查询到
            string temp_text = sea_text.Text.Trim();//得到搜索框内文本

            seach_button.Text = "查找下一个";
            if(seach_text.Equals(temp_text))//如果两次查询文本相同
            {
                i = last_i + 1;//回到上次的查询位置后一位
            }
            else
            {
                i = 0;//不同则从头开始
                seach_text = sea_text.Text.Trim();//存储本次的搜索文字
            }
            for (; i < row; i++)//在总行数之内循环 
            {
                if (Compare(temp_text, dataGridView.Rows[i].Cells[j].Value.ToString().Trim()))
                {
                    if (flag)
                    {
                        dataGridView.CurrentCell = dataGridView[j, i];//定位到相同的单元格
                        flag = false;
                        last_i = i;//更新本次查询到的位置
                    }
                    flag2 = true;
                    dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                }
            }
            if (!flag2)
            {
                seach_button.Text = "查询";
                MessageBox.Show("没有找到相关信息", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                last_i = -1;
            }

        }
        /// <summary>
        /// 搜索框点击后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sea_text_Click(object sender, EventArgs e)
        {
            sea_text.Text = "";
            seach_button.Text = "查询";
            for(int i = 0; i < dataGridView.Rows.Count; ++i)//清除单元格上的色彩
                for(int j = 0; j < dataGridView.Rows[i].Cells.Count; ++j)
                    dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
            dataGridView.CurrentCell = dataGridView[comboBox.SelectedIndex, 0];
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="a">需要匹配的字符串</param>
        /// <param name="b">被匹配的字符串</param>
        /// <returns></returns>
        private bool Compare(string a, string b)
        {
            Match m = Regex.Match(b, "\\S*" + a + "\\S*");
            return m.Success;
        }
        /// <summary>
        /// 下拉框改变后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            sea_text.Text = "";
            seach_button.Text = "查询";
            for (int i = 0; i < dataGridView.Rows.Count; ++i)//清除单元格上的色彩
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; ++j)
                    dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
            dataGridView.CurrentCell = dataGridView[comboBox.SelectedIndex, 0];
        }
        /// <summary>
        /// 输入查询关键字后回车
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sea_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seach_button_Click(sender, e);
            }
        }
        /// <summary>
        /// 返回单元格改变前的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            frevalue =  this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            value = e.FormattedValue.ToString();
            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (frevalue != value && frevalue != "0000")
            {
                DB.DB.Open();
                if (!DB.DB.UpdateData(value, id, dataGridView.Columns[e.ColumnIndex].DataPropertyName))
                {
                    MessageBox.Show("更改失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
                else if (dataGridView.Columns[e.ColumnIndex].DataPropertyName == "work_status")
                {
                    if (value == "False")
                    {
                        string rea = Interaction.InputBox("请输入该员工离职原因");
                        if(DB.DB.ChangeStatus(id, rea))
                            MessageBox.Show("修改成功");
                        else
                            MessageBox.Show("修改失败");
                    }
                    else if(value == "True")
                    {
                        if (DB.DB.ChangeStatus(id))
                            MessageBox.Show("修改成功");
                        else
                            MessageBox.Show("修改失败");
                    }
                }
                DB.DB.Close();
            }

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Move move = new Move();
            move.Closefather += new Move.childclose(this.Closefather);
            move.Returnfather += new Move.Return(this.ReturnFather);
            move.Show();
            this.Hide();
        }

        private void ReturnFather()
        {
            Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "在职")
            {
                this.dataGridView.DataSource = DB.DB.GetActivity();
            }
            else if (comboBox1.SelectedItem == "离职")
            {
                this.dataGridView.AutoGenerateColumns = true;
                this.dataGridView.DataSource = DB.DB.GetLeave();
            }
            else
            {
                this.dataGridView.DataSource = DB.DB.GetData();
            }
            int i = 1;
        }
    }
}
