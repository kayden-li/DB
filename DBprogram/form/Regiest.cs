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
    public partial class Regiest : Form
    {
        public delegate void Return();
        public event Return returnfather;

        public Regiest()
        {
            
            this.BackgroundImage = Image.FromFile("../../accessory/regiest.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            InitializeComponent();
            
            textBox2.MaxLength = 20;
        }

        private void Regiest_Load(object sender, EventArgs e)
        {

        }

        private void return_login_Click(object sender, EventArgs e)
        {
            try
            {
                returnfather();
                Close();
            }
            catch
            {
                MessageBox.Show("出现异常", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Regiest_Resize(object sender, EventArgs e)
        {
            Point reg = new Point(this.Width / 2, this.Height - 130);
            Point ret = new Point(this.Width / 3, this.Height - 130);
            regeist.Location = reg;
            return_login.Location = ret;
        }

        private void Regiest_Leave(object sender, EventArgs e)
        {
        }

        private void Regiest_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ("".Equals(textBox2.Text))
            {
                MessageBox.Show("密码长度错误，请重新输入！");
                textBox2.Text = "";
            }
        }

        private void regeist_Click(object sender, EventArgs e)
        {
            bool flag = false;
            DB.DB.Open();
            string[] temp = new string[3];
            temp[0] = DB.DB.GetUserNum();
            temp[1] = textBox2.Text;
            temp[2] = textBox1.Text;
            if(temp[1] == "" || temp[2] == "")
            {
                MessageBox.Show("请完善资料！");
                return;
            }

            flag = DB.DB.Regiest(temp[0], temp[1], temp[2]);
            DB.DB.Close();
            if (flag)
            {
                MessageBox.Show("您的账号为"+temp[0]+"\n请牢记");
                returnfather();
                Close();
            }
        }
    }
}
