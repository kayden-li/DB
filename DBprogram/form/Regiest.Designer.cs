namespace DBprogram
{
    partial class Regiest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regiest));
            this.regeist = new System.Windows.Forms.Button();
            this.return_login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regeist
            // 
            this.regeist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regeist.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.regeist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regeist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.regeist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regeist.Location = new System.Drawing.Point(558, 414);
            this.regeist.Name = "regeist";
            this.regeist.Size = new System.Drawing.Size(85, 35);
            this.regeist.TabIndex = 6;
            this.regeist.Text = "注册";
            this.regeist.UseVisualStyleBackColor = false;
            this.regeist.Click += new System.EventHandler(this.regeist_Click);
            // 
            // return_login
            // 
            this.return_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.return_login.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.return_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.return_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.return_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_login.Location = new System.Drawing.Point(366, 414);
            this.return_login.Name = "return_login";
            this.return_login.Size = new System.Drawing.Size(85, 35);
            this.return_login.TabIndex = 7;
            this.return_login.Text = "返回";
            this.return_login.UseVisualStyleBackColor = false;
            this.return_login.Click += new System.EventHandler(this.return_login_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password.Font = new System.Drawing.Font("宋体", 20F);
            this.password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.Location = new System.Drawing.Point(277, 213);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(83, 34);
            this.password.TabIndex = 11;
            this.password.Text = "密码";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox2.Location = new System.Drawing.Point(366, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 36);
            this.textBox2.TabIndex = 10;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("宋体", 15F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(590, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "0~20字节以内";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 34);
            this.label1.TabIndex = 45;
            this.label1.Text = "请设置您的密码，账号将会由系统发放";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(590, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "这是你找回账号的必要信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(277, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 47;
            this.label3.Text = "邮箱";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox1.Location = new System.Drawing.Point(366, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 36);
            this.textBox1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(559, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(559, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "*";
            // 
            // Regiest
            // 
            this.ClientSize = new System.Drawing.Size(1006, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.return_login);
            this.Controls.Add(this.regeist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Regiest";
            this.Load += new System.EventHandler(this.Regiest_Load_1);
            this.Leave += new System.EventHandler(this.Regiest_Leave);
            this.Resize += new System.EventHandler(this.Regiest_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button regeist;
        private System.Windows.Forms.Button return_login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}