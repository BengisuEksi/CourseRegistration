using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void student_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentEntry fr = new StudentEntry();
            this.Hide();
            fr.ShowDialog();
        }

        private void teacher_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeacherEntry fr = new TeacherEntry();
            this.Hide();
            fr.ShowDialog();
        }

        private void admin_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminEntry fr = new AdminEntry();
            this.Hide();
            fr.ShowDialog();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void student_lbl_MouseEnter(object sender, EventArgs e)
        {
            student_lbl.BackColor = Color.DarkSeaGreen;
        }

        private void student_lbl_MouseLeave(object sender, EventArgs e)
        {
            student_lbl.BackColor = Color.Transparent;
        }

        private void teacher_lbl_MouseEnter(object sender, EventArgs e)
        {
            teacher_lbl.BackColor = Color.DarkSeaGreen;
        }

        private void teacher_lbl_MouseLeave(object sender, EventArgs e)
        {
            teacher_lbl.BackColor = Color.Transparent;
        }

        private void admin_lbl_MouseEnter(object sender, EventArgs e)
        {
            admin_lbl.BackColor = Color.DarkSeaGreen;
        }

        private void admin_lbl_MouseLeave(object sender, EventArgs e)
        {
            admin_lbl.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
