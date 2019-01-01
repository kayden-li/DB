using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBprogram.form
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pwd = textBox2.Text;
            if (pwd == "")
            {
                MessageBox.Show("请输入邮箱!");
                return;
            }
                
            DB.DB.Open();
            MessageBox.Show(DB.DB.Find(id, pwd));
            DB.DB.Close();
        }
    }
}
