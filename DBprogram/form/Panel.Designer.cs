namespace DBprogram
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.exitButton = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.searcher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(844, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // move
            // 
            this.move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.move.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.move.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.move.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.move.Image = ((System.Drawing.Image)(resources.GetObject("move.Image")));
            this.move.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.move.Location = new System.Drawing.Point(67, 91);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(114, 122);
            this.move.TabIndex = 6;
            this.move.Text = "添加人员";
            this.move.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.move.UseVisualStyleBackColor = false;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // searcher
            // 
            this.searcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searcher.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.searcher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.searcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searcher.Image = ((System.Drawing.Image)(resources.GetObject("searcher.Image")));
            this.searcher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searcher.Location = new System.Drawing.Point(234, 91);
            this.searcher.Name = "searcher";
            this.searcher.Size = new System.Drawing.Size(114, 122);
            this.searcher.TabIndex = 7;
            this.searcher.Text = "数据查询";
            this.searcher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searcher.UseVisualStyleBackColor = false;
            this.searcher.Click += new System.EventHandler(this.search_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 496);
            this.Controls.Add(this.searcher);
            this.Controls.Add(this.move);
            this.Controls.Add(this.exitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.Resize += new System.EventHandler(this.Panel_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button searcher;
    }
}