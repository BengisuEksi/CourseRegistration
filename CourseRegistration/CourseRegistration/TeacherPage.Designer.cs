namespace CourseRegistration
{
    partial class TeacherPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPage));
            this.label1 = new System.Windows.Forms.Label();
            this.fullname_lbl = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.number_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logout_bttn = new System.Windows.Forms.Button();
            this.viewcourses_bttn = new System.Windows.Forms.Button();
            this.update_bttn = new System.Windows.Forms.Button();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.branch_txtbox = new System.Windows.Forms.TextBox();
            this.surname_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fullname_lbl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullname_lbl.Location = new System.Drawing.Point(151, 28);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(48, 25);
            this.fullname_lbl.TabIndex = 1;
            this.fullname_lbl.Text = "null";
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit_bttn.Location = new System.Drawing.Point(824, 2);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 7;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.id_txtbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.number_txtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.logout_bttn);
            this.groupBox1.Controls.Add(this.viewcourses_bttn);
            this.groupBox1.Controls.Add(this.update_bttn);
            this.groupBox1.Controls.Add(this.password_txtbox);
            this.groupBox1.Controls.Add(this.branch_txtbox);
            this.groupBox1.Controls.Add(this.surname_txtbox);
            this.groupBox1.Controls.Add(this.name_txtbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // id_txtbox
            // 
            this.id_txtbox.Enabled = false;
            this.id_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_txtbox.Location = new System.Drawing.Point(109, 37);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(174, 27);
            this.id_txtbox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(73, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID: ";
            // 
            // number_txtbox
            // 
            this.number_txtbox.Enabled = false;
            this.number_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_txtbox.Location = new System.Drawing.Point(395, 113);
            this.number_txtbox.Name = "number_txtbox";
            this.number_txtbox.Size = new System.Drawing.Size(174, 27);
            this.number_txtbox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(322, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number:";
            // 
            // logout_bttn
            // 
            this.logout_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_bttn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logout_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_bttn.Location = new System.Drawing.Point(612, 119);
            this.logout_bttn.Name = "logout_bttn";
            this.logout_bttn.Size = new System.Drawing.Size(174, 35);
            this.logout_bttn.TabIndex = 6;
            this.logout_bttn.Text = "Log Out";
            this.logout_bttn.UseVisualStyleBackColor = true;
            this.logout_bttn.Click += new System.EventHandler(this.logout_bttn_Click);
            this.logout_bttn.MouseEnter += new System.EventHandler(this.logout_bttn_MouseEnter);
            this.logout_bttn.MouseLeave += new System.EventHandler(this.logout_bttn_MouseLeave);
            // 
            // viewcourses_bttn
            // 
            this.viewcourses_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewcourses_bttn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.viewcourses_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewcourses_bttn.Location = new System.Drawing.Point(612, 78);
            this.viewcourses_bttn.Name = "viewcourses_bttn";
            this.viewcourses_bttn.Size = new System.Drawing.Size(174, 35);
            this.viewcourses_bttn.TabIndex = 5;
            this.viewcourses_bttn.Text = "View Courses";
            this.viewcourses_bttn.UseVisualStyleBackColor = true;
            this.viewcourses_bttn.Click += new System.EventHandler(this.viewcourses_bttn_Click);
            this.viewcourses_bttn.MouseEnter += new System.EventHandler(this.viewcourses_bttn_MouseEnter);
            this.viewcourses_bttn.MouseLeave += new System.EventHandler(this.viewcourses_bttn_MouseLeave);
            // 
            // update_bttn
            // 
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_bttn.Location = new System.Drawing.Point(612, 37);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(174, 35);
            this.update_bttn.TabIndex = 4;
            this.update_bttn.Text = "Update";
            this.update_bttn.UseVisualStyleBackColor = true;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            this.update_bttn.MouseEnter += new System.EventHandler(this.upgrade_bttn_MouseEnter);
            this.update_bttn.MouseLeave += new System.EventHandler(this.upgrade_bttn_MouseLeave);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_txtbox.Location = new System.Drawing.Point(395, 75);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(174, 27);
            this.password_txtbox.TabIndex = 3;
            // 
            // branch_txtbox
            // 
            this.branch_txtbox.Enabled = false;
            this.branch_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.branch_txtbox.Location = new System.Drawing.Point(395, 37);
            this.branch_txtbox.Name = "branch_txtbox";
            this.branch_txtbox.Size = new System.Drawing.Size(174, 27);
            this.branch_txtbox.TabIndex = 30;
            // 
            // surname_txtbox
            // 
            this.surname_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname_txtbox.Location = new System.Drawing.Point(109, 113);
            this.surname_txtbox.Name = "surname_txtbox";
            this.surname_txtbox.Size = new System.Drawing.Size(174, 27);
            this.surname_txtbox.TabIndex = 2;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_txtbox.Location = new System.Drawing.Point(109, 75);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(174, 27);
            this.name_txtbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(312, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(327, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Branch: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 200);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.fullname_lbl);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPage";
            this.Load += new System.EventHandler(this.TeacherPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullname_lbl;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logout_bttn;
        private System.Windows.Forms.Button viewcourses_bttn;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox branch_txtbox;
        private System.Windows.Forms.TextBox surname_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox number_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label label7;
    }
}