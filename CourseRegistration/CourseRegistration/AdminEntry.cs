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
    public partial class AdminEntry : Form
    {
        public AdminEntry()
        {
            InitializeComponent();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void login_bttn_MouseEnter(object sender, EventArgs e)
        {
            login_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void login_bttn_MouseLeave(object sender, EventArgs e)
        {
            login_bttn.BackColor = Color.Transparent;
        }

        private void login_bttn_Click(object sender, EventArgs e)
        {
            if(name_txtbox.Text == "user" & password_txtbox.Text == "password")
            {
                AdminPage fr = new AdminPage();
                this.Hide();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid name or password.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                name_txtbox.Text = "";
                password_txtbox.Text = "";
                name_txtbox.Focus();
            }
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_bttn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
        }

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }
    }
}
