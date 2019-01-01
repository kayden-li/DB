using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBprogram
{
    public partial class Login : Form
    {
        public Login()
        {
            this.BackgroundImage = Image.FromFile("../../accessory/bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            InitializeComponent();
        }
        private void loginBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 10)
            {
                MessageBox.Show("账户格式错误！");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                bool flag = true;
                string id = textBox1.Text;
                string password = textBox2.Text;
                DB.DB.Open();
                flag = DB.DB.Load(id, password);
                DB.DB.Close();
                if (flag)
                {
                    Panel panel = new Panel();
                    Hide();
                    panel.Closefather += new Panel.childclose(this.Closefather);
                    panel.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败,请重新登录！");
                    textBox2.Text = "";
                }
            }
        }

        private void regeistButton_Click(object sender, EventArgs e)
        {

            Regiest regiest = new Regiest();
            Hide();
            regiest.returnfather += new Regiest.Return(Returnfather);
            regiest.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 关闭程序
        /// </summary>
        public void Closefather()
        {
            Close();
        }
        /// <summary>
        /// 返回主界面
        /// </summary>
        public void Returnfather()
        {
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DBprogram.form.Find find = new form.Find();
            find.Show();

        }
    }
}
