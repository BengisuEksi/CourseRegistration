namespace CourseRegistration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.student_lbl = new System.Windows.Forms.LinkLabel();
            this.teacher_lbl = new System.Windows.Forms.LinkLabel();
            this.admin_lbl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Registration System";
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(520, 1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 1;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // student_lbl
            // 
            this.student_lbl.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.student_lbl.AutoSize = true;
            this.student_lbl.BackColor = System.Drawing.Color.Transparent;
            this.student_lbl.LinkColor = System.Drawing.Color.Black;
            this.student_lbl.Location = new System.Drawing.Point(85, 100);
            this.student_lbl.Name = "student_lbl";
            this.student_lbl.Size = new System.Drawing.Size(115, 22);
            this.student_lbl.TabIndex = 2;
            this.student_lbl.TabStop = true;
            this.student_lbl.Text = "Student Entry";
            this.student_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.student_lbl_LinkClicked);
            this.student_lbl.MouseEnter += new System.EventHandler(this.student_lbl_MouseEnter);
            this.student_lbl.MouseLeave += new System.EventHandler(this.student_lbl_MouseLeave);
            // 
            // teacher_lbl
            // 
            this.teacher_lbl.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.teacher_lbl.AutoSize = true;
            this.teacher_lbl.BackColor = System.Drawing.Color.Transparent;
            this.teacher_lbl.LinkColor = System.Drawing.Color.Black;
            this.teacher_lbl.Location = new System.Drawing.Point(85, 160);
            this.teacher_lbl.Name = "teacher_lbl";
            this.teacher_lbl.Size = new System.Drawing.Size(120, 22);
            this.teacher_lbl.TabIndex = 3;
            this.teacher_lbl.TabStop = true;
            this.teacher_lbl.Text = "Teacher Entry";
            this.teacher_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teacher_lbl_LinkClicked);
            this.teacher_lbl.MouseEnter += new System.EventHandler(this.teacher_lbl_MouseEnter);
            this.teacher_lbl.MouseLeave += new System.EventHandler(this.teacher_lbl_MouseLeave);
            // 
            // admin_lbl
            // 
            this.admin_lbl.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_lbl.LinkColor = System.Drawing.Color.Black;
            this.admin_lbl.Location = new System.Drawing.Point(288, 100);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(110, 22);
            this.admin_lbl.TabIndex = 4;
            this.admin_lbl.TabStop = true;
            this.admin_lbl.Text = "Admin Entry";
            this.admin_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_lbl_LinkClicked);
            this.admin_lbl.MouseEnter += new System.EventHandler(this.admin_lbl_MouseEnter);
            this.admin_lbl.MouseLeave += new System.EventHandler(this.admin_lbl_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(33, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 42);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(236, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 42);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 256);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_lbl);
            this.Controls.Add(this.teacher_lbl);
            this.Controls.Add(this.student_lbl);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.LinkLabel student_lbl;
        private System.Windows.Forms.LinkLabel teacher_lbl;
        private System.Windows.Forms.LinkLabel admin_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

