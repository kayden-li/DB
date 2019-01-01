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
    public partial class Move : Form
    {
        public delegate void childclose();
        public event childclose Closefather;
        public delegate void Return();
        public event Return Returnfather;

        public Move()
        {
            this.BackgroundImage = Image.FromFile("../../accessory/regiest.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
        }
        /// <summary>
        /// 返回本界面
        /// </summary>
        public void ReturnFather()
        {
            Show();
        }

        private void Move_Load(object sender, EventArgs e)
        {

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

        private void Move_Resize(object sender, EventArgs e)
        {
            Point exit = new Point(this.Width - 180, 10);
            Point ret = new Point(this.Width - 350, 10);
            exitButton.Location = exit;
            return_Panel.Location = ret;
            button1.Location = new Point(this.Width - 10, this.Height - 10);
            button2.Location = new Point(20, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] info = new string[13];
            DB.DB.Open();
            info[i++] = DB.DB.GetData().Tables["employee"].Rows.Count.ToString("0000");
            info[i++] = text1.Text;
            info[i++] = text2.Text;
            info[i++] = text3.Text;
            info[i++] = text4.Text;
            info[i++] = text5.Text;
            info[i++] = text6.Checked.ToString();
            info[i++] = text7.Text;
            info[i++] = text8.Text;
            info[i++] = text9.Text;
            info[i++] = text10.Text;
            info[i++] = text11.Text;
            info[i++] = text12.Checked.ToString();
            if (DB.DB.AddMember(info))
            {
                MessageBox.Show("添加成功！");
                text1.Text = "";
                text2.Text = "";
                text3.Text = "";
                text4.Text = "";
                text5.Text = "";
                text6.Checked = false;
                text7.Text = "";
                text8.Text = "";
                text9.Text = "";
                text10.Text = "";
                text11.Text = "";
                text12.Checked = false;
            }
            else MessageBox.Show("添加失败，请检查信息后重新填入！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DB.DB.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Closefather += new Search.childclose(this.Closefather);
            search.Returnfather += new Search.Return(this.ReturnFather);
            search.Show();
            this.Hide();
        }
    }
}
