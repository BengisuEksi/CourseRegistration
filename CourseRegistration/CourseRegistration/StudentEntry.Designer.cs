namespace CourseRegistration
{
    partial class StudentEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEntry));
            this.exit_bttn = new System.Windows.Forms.Button();
            this.back_bttn = new System.Windows.Forms.Button();
            this.login_bttn = new System.Windows.Forms.Button();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.studentnumber_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.exit_bttn.TabIndex = 5;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Transparent;
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bttn.Location = new System.Drawing.Point(487, 1);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(30, 30);
            this.back_bttn.TabIndex = 4;
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            this.back_bttn.MouseEnter += new System.EventHandler(this.back_bttn_MouseEnter);
            this.back_bttn.MouseLeave += new System.EventHandler(this.back_bttn_MouseLeave);
            // 
            // login_bttn
            // 
            this.login_bttn.BackColor = System.Drawing.Color.Transparent;
            this.login_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_bttn.Location = new System.Drawing.Point(298, 181);
            this.login_bttn.Name = "login_bttn";
            this.login_bttn.Size = new System.Drawing.Size(144, 32);
            this.login_bttn.TabIndex = 3;
            this.login_bttn.Text = "Log In";
            this.login_bttn.UseVisualStyleBackColor = false;
            this.login_bttn.Click += new System.EventHandler(this.login_bttn_Click);
            this.login_bttn.MouseEnter += new System.EventHandler(this.login_bttn_MouseEnter);
            this.login_bttn.MouseLeave += new System.EventHandler(this.login_bttn_MouseLeave);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(203, 142);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(239, 30);
            this.password_txtbox.TabIndex = 2;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // studentnumber_txtbox
            // 
            this.studentnumber_txtbox.Location = new System.Drawing.Point(203, 103);
            this.studentnumber_txtbox.Name = "studentnumber_txtbox";
            this.studentnumber_txtbox.Size = new System.Drawing.Size(239, 30);
            this.studentnumber_txtbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(98, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Entry";
            // 
            // StudentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 256);
            this.Controls.Add(this.login_bttn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.studentnumber_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.exit_bttn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Button login_bttn;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox studentnumber_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}