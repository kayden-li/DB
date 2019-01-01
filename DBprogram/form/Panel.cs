using DBprogram.form;
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
    public partial class Panel : Form
    {
        public delegate void childclose();
        public event childclose Closefather;

        public Panel()
        {
            this.BackgroundImage = Image.FromFile("../../accessory/panel.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
        }

        private void move_Click(object sender, EventArgs e)
        {
            Move move = new Move();
            this.Hide();
            move.Closefather += new Move.childclose(this.Closefather);
            move.Returnfather += new Move.Return(this.Returnfather);
            move.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            search.Closefather += new Search.childclose(this.Closefather);
            search.Returnfather += new Search.Return(this.Returnfather);
            search.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Closefather();
            }
            catch(Exception)
            {
                MessageBox.Show("出现异常", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 返回主界面
        /// </summary>
        public void Returnfather()
        {
            Show();
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            Point search = new Point(this.Width / 4, this.Height / 6);
            Point mov = new Point(this.Width / 15, this.Height / 6);
            Point exit = new Point(this.Width - 280, this.Height / 15);
            searcher.Location = search;
            move.Location = mov;
            exitButton.Location = exit;
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
