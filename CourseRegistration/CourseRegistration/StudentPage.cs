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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }
        public string full_name;
        public string number;
        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBCourseRegistration;Integrated Security=True");

        private void StudentPage_Load(object sender, EventArgs e)
        {
            fullname_lbl.Text = full_name;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Student where StudentNumber = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id_txtbox.Text = dr[0].ToString();
                name_txtbox.Text = dr[1].ToString();
                surname_txtbox.Text = dr[2].ToString();
                pictureBox1.ImageLocation = dr[3].ToString();
                class_txtbox.Text = dr[4].ToString();
                phone_txtbox.Text = dr[5].ToString();
                mail_txtbox.Text = dr[6].ToString();
                password_txtbox.Text = dr[7].ToString();
                studentnumber_txtbox.Text = dr[8].ToString();
            }
            conn.Close();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.LightGray;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void photo_bttn_MouseEnter(object sender, EventArgs e)
        {
            photo_bttn.BackColor = Color.LightGray;
        }

        private void photo_bttn_MouseLeave(object sender, EventArgs e)
        {
            photo_bttn.BackColor = Color.Transparent;
        }

        private void update_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.LightGray;
        }

        private void update_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void viewcourses_bttn_MouseEnter(object sender, EventArgs e)
        {
            viewcourses_bttn.BackColor = Color.LightGray;
        }

        private void viewcourses_bttn_MouseLeave(object sender, EventArgs e)
        {
            viewcourses_bttn.BackColor = Color.Transparent;
        }

        private void logout_bttn_MouseEnter(object sender, EventArgs e)
        {
            logout_bttn.BackColor = Color.LightGray;
        }

        private void logout_bttn_MouseLeave(object sender, EventArgs e)
        {
            logout_bttn.BackColor = Color.Transparent;
        }

        private void photo_bttn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            if(name_txtbox.Text == "" || surname_txtbox.Text == "" || phone_txtbox.Text == "" || mail_txtbox.Text == "" || password_txtbox.Text == "")
            {
                MessageBox.Show("Fill all the blank fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_Student set Name=@p1,Surname=@p2,Photograph=@p3,Class=@p4,Phone=@p5,Mail=@p6,Password=@p7, StudentNumber=@p8 where StudentID=@p9", conn);
                cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
                cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text);
                fullname_lbl.Text = name_txtbox.Text + " " + surname_txtbox.Text;
                cmd.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
                cmd.Parameters.AddWithValue("@p4", class_txtbox.Text);
                cmd.Parameters.AddWithValue("@p5", phone_txtbox.Text);
                cmd.Parameters.AddWithValue("@p6", mail_txtbox.Text);
                cmd.Parameters.AddWithValue("@p7", password_txtbox.Text);
                cmd.Parameters.AddWithValue("@p8", studentnumber_txtbox.Text);
                cmd.Parameters.AddWithValue("@p9", id_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your information is updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                StudentEntry fr = new StudentEntry();
                this.Close();
                fr.Show();
            }
        }

        private void viewcourses_bttn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID,Tbl_Branch.BranchName,(Tbl_Teacher.Name+' '+Tbl_Teacher.Surname) as Teacher,(Tbl_Student.Name+' '+Tbl_Student.Surname) as Student,Date,Time,Status from Tbl_Course \r\ninner join Tbl_Branch\r\non Tbl_Course.BranchID = Tbl_Branch.BranchID\r\ninner join Tbl_Teacher\r\non Tbl_Course.TeacherID = Tbl_Teacher.TeacherID\r\ninner join Tbl_Student\r\non Tbl_Course.StudentID = Tbl_Student.StudentID \r\nwhere Tbl_Student.StudentID=" + id_txtbox.Text, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
