namespace DBprogram
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.return_Panel = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.work_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deparment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.background = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.married = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.school_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBprogramDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seach_button = new System.Windows.Forms.Button();
            this.sea_text = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBprogramDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // return_Panel
            // 
            this.return_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.return_Panel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.return_Panel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.return_Panel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.return_Panel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_Panel.Location = new System.Drawing.Point(799, 13);
            this.return_Panel.Name = "return_Panel";
            this.return_Panel.Size = new System.Drawing.Size(150, 35);
            this.return_Panel.TabIndex = 6;
            this.return_Panel.TabStop = false;
            this.return_Panel.Text = "返回上一页";
            this.return_Panel.UseVisualStyleBackColor = false;
            this.return_Panel.Click += new System.EventHandler(this.return_Panel_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(955, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.work_id,
            this.name,
            this.sex,
            this.age,
            this.join_time,
            this.work_status,
            this.deparment,
            this.position,
            this.title,
            this.wage,
            this.bonus,
            this.background,
            this.married,
            this.school_name});
            this.dataGridView.DataSource = this.dBprogramDataSetBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 53);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(1093, 431);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // work_id
            // 
            this.work_id.DataPropertyName = "work_id";
            this.work_id.HeaderText = "工号";
            this.work_id.Name = "work_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            // 
            // join_time
            // 
            this.join_time.DataPropertyName = "join_time";
            this.join_time.HeaderText = "入职时间";
            this.join_time.Name = "join_time";
            // 
            // work_status
            // 
            this.work_status.DataPropertyName = "work_status";
            this.work_status.HeaderText = "是否在职";
            this.work_status.Name = "work_status";
            this.work_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.work_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deparment
            // 
            this.deparment.DataPropertyName = "deparment";
            this.deparment.HeaderText = "部门";
            this.deparment.Name = "deparment";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "职位";
            this.position.Name = "position";
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "职称";
            this.title.Name = "title";
            // 
            // wage
            // 
            this.wage.DataPropertyName = "wage";
            this.wage.HeaderText = "工资";
            this.wage.Name = "wage";
            // 
            // bonus
            // 
            this.bonus.DataPropertyName = "bonus";
            this.bonus.HeaderText = "奖金(万元)";
            this.bonus.Name = "bonus";
            // 
            // background
            // 
            this.background.DataPropertyName = "background";
            this.background.HeaderText = "学历";
            this.background.Name = "background";
            // 
            // married
            // 
            this.married.DataPropertyName = "married";
            this.married.HeaderText = "婚否";
            this.married.Name = "married";
            this.married.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // school_name
            // 
            this.school_name.DataPropertyName = "school_name";
            this.school_name.HeaderText = "毕业院校";
            this.school_name.Name = "school_name";
            // 
            // seach_button
            // 
            this.seach_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.seach_button.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.seach_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.seach_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.seach_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seach_button.Location = new System.Drawing.Point(400, 12);
            this.seach_button.Name = "seach_button";
            this.seach_button.Size = new System.Drawing.Size(98, 35);
            this.seach_button.TabIndex = 3;
            this.seach_button.TabStop = false;
            this.seach_button.Text = "查询";
            this.seach_button.UseVisualStyleBackColor = false;
            this.seach_button.Click += new System.EventHandler(this.seach_button_Click);
            // 
            // sea_text
            // 
            this.sea_text.Font = new System.Drawing.Font("宋体", 15F);
            this.sea_text.Location = new System.Drawing.Point(139, 11);
            this.sea_text.Name = "sea_text";
            this.sea_text.Size = new System.Drawing.Size(255, 36);
            this.sea_text.TabIndex = 2;
            this.sea_text.Text = "请输入需要查询的文字";
            this.sea_text.Click += new System.EventHandler(this.sea_text_Click);
            this.sea_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sea_text_KeyDown);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "工号",
            "姓名",
            "性别",
            "年龄",
            "入职时间",
            "部门",
            "职位",
            "职称",
            "工资",
            "奖金",
            "学历",
            "毕业院校"});
            this.comboBox.Location = new System.Drawing.Point(12, 9);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 35);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataSource = this.dBprogramDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(698, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "添加新成员";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "在职",
            "离职",
            "全部"});
            this.comboBox1.Location = new System.Drawing.Point(516, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 35);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 496);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.sea_text);
            this.Controls.Add(this.seach_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.return_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.Resize += new System.EventHandler(this.Search_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBprogramDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button return_Panel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dBprogramDataSetBindingSource;
        private System.Windows.Forms.Button seach_button;
        private System.Windows.Forms.TextBox sea_text;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.BindingSource baseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_time;
        private System.Windows.Forms.DataGridViewCheckBoxColumn work_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn deparment;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn wage;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn background;
        private System.Windows.Forms.DataGridViewCheckBoxColumn married;
        private System.Windows.Forms.DataGridViewTextBoxColumn school_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}