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
    public partial class TeacherPage : Form
    {
        public TeacherPage()
        {
            InitializeComponent();
        }
        public string full_name;
        public string number;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBCourseRegistration;Integrated Security=True");

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {
            fullname_lbl.Text = full_name;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TeacherID, Name,Surname,Tbl_Branch.BranchName,Password,TeacherNumber from Tbl_Teacher\r\ninner join Tbl_Branch\r\non Tbl_Teacher.BranchID = Tbl_Branch.BranchID\r\nwhere Tbl_Teacher.TeacherNumber=" + number, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id_txtbox.Text = dr["TeacherID"].ToString();
                name_txtbox.Text = dr["Name"].ToString();
                surname_txtbox.Text = dr["Surname"].ToString();
                branch_txtbox.Text = dr["BranchName"].ToString();
                password_txtbox.Text = dr["Password"].ToString();
                number_txtbox.Text = dr["TeacherNumber"].ToString();
            }
            conn.Close();
        }

        private void upgrade_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void upgrade_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void viewcourses_bttn_MouseEnter(object sender, EventArgs e)
        {
            viewcourses_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void viewcourses_bttn_MouseLeave(object sender, EventArgs e)
        {
            viewcourses_bttn.BackColor = Color.Transparent;
        }

        private void logout_bttn_MouseEnter(object sender, EventArgs e)
        {
            logout_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void logout_bttn_MouseLeave(object sender, EventArgs e)
        {
            logout_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = SystemColors.ActiveCaption;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }



        private void logout_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to log out?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                TeacherEntry fr = new TeacherEntry();
                this.Close();
                fr.Show();
            }
        }

        private void viewcourses_bttn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID, Tbl_Branch.BranchName as Branch,(Tbl_Teacher.Name+' '+Tbl_Teacher.Surname) as Teacher, (Tbl_Student.Name+' '+Tbl_Student.Surname) as Student, Date,Time,Status from Tbl_Course\r\ninner join Tbl_Branch\r\non Tbl_Course.BranchID = Tbl_Branch.BranchID\r\ninner join Tbl_Student\r\non Tbl_Course.StudentID = Tbl_Student.StudentID\r\ninner join Tbl_Teacher\r\non Tbl_Course.TeacherID = Tbl_Teacher.TeacherID\r\nwhere Tbl_Teacher.TeacherID="+id_txtbox.Text, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            if (name_txtbox.Text == "" || surname_txtbox.Text == "" || branch_txtbox.Text == "" || password_txtbox.Text == "" || number_txtbox.Text == "")
            {
                MessageBox.Show("Fill all the blank fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand branchCmd = new SqlCommand("Select BranchID from Tbl_Branch where BranchName = @p1", conn); 
                branchCmd.Parameters.AddWithValue("@p1", branch_txtbox.Text); 
                var branchID = branchCmd.ExecuteScalar(); 
                if (branchID != null) 
                { 
                    SqlCommand cmd = new SqlCommand("Update Tbl_Teacher set Name=@p1, Surname=@p2, Password=@p3, TeacherNumber=@p4, BranchID=@p5 where TeacherID=@p6", conn); 
                    cmd.Parameters.AddWithValue("@p1", name_txtbox.Text); 
                    cmd.Parameters.AddWithValue("@p2", surname_txtbox.Text); 
                    cmd.Parameters.AddWithValue("@p3", password_txtbox.Text); 
                    cmd.Parameters.AddWithValue("@p4", number_txtbox.Text); 
                    cmd.Parameters.AddWithValue("@p5", Convert.ToInt32(branchID)); 
                    cmd.Parameters.AddWithValue("@p6", id_txtbox.Text); 
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Your information is updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                } 
                else 
                { 
                    MessageBox.Show("Branch not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }
    }
}
