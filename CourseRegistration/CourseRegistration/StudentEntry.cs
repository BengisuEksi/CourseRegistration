using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistration
{
    public partial class StudentEntry : Form
    {
        public StudentEntry()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBCourseRegistration;Integrated Security=True");
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

        private void back_bttn_MouseEnter(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void back_bttn_MouseLeave(object sender, EventArgs e)
        {
            back_bttn.BackColor = Color.Transparent;
        }

        private void login_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Student where StudentNumber = @p1 and Password = @p2", conn);
            cmd.Parameters.AddWithValue("@p1",studentnumber_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", password_txtbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                StudentPage fr = new StudentPage();
                fr.full_name = dr[1].ToString() + " " + dr[2].ToString();
                fr.number = dr[8].ToString();
                this.Hide();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid name or password.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                studentnumber_txtbox.Text = "";
                password_txtbox.Text = "";
                studentnumber_txtbox.Focus();
            }
            conn.Close();
        }
    }
}
