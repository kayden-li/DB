using System.Drawing;
using System.Windows.Forms;

namespace DBprogram
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.regeistButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginBox.Controls.Add(this.label1);
            this.loginBox.Controls.Add(this.regeistButton);
            this.loginBox.Controls.Add(this.loginButton);
            this.loginBox.Controls.Add(this.password);
            this.loginBox.Controls.Add(this.textBox2);
            this.loginBox.Controls.Add(this.user_id);
            this.loginBox.Controls.Add(this.textBox1);
            this.loginBox.Location = new System.Drawing.Point(266, 86);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(495, 305);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            this.loginBox.Enter += new System.EventHandler(this.loginBox_Enter);
            // 
            // regeistButton
            // 
            this.regeistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regeistButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.regeistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regeistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.regeistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regeistButton.Location = new System.Drawing.Point(273, 223);
            this.regeistButton.Name = "regeistButton";
            this.regeistButton.Size = new System.Drawing.Size(85, 35);
            this.regeistButton.TabIndex = 5;
            this.regeistButton.Text = "注册";
            this.regeistButton.UseVisualStyleBackColor = false;
            this.regeistButton.Click += new System.EventHandler(this.regeistButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(147, 223);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(85, 35);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password.Location = new System.Drawing.Point(144, 175);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 15);
            this.password.TabIndex = 3;
            this.password.Text = "密码";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 25);
            this.textBox2.TabIndex = 2;
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.user_id.Location = new System.Drawing.Point(144, 119);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(37, 15);
            this.user_id.TabIndex = 1;
            this.user_id.Text = "账号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 25);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(364, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "找回密码";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 496);
            this.Controls.Add(this.loginBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "人事管理系统";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginBox;
        private Label user_id;
        private TextBox textBox1;
        private Button regeistButton;
        private Button loginButton;
        private Label password;
        private TextBox textBox2;
        private Label label1;
    }
}

