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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=DBCourseRegistration;Integrated Security=True");

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to sign out?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                AdminEntry fr = new AdminEntry();
                this.Hide();
                fr.ShowDialog();
            }
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void addTeacher_bttn_MouseEnter(object sender, EventArgs e)
        {
            addTeacher_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void addTeacher_bttn_MouseLeave(object sender, EventArgs e)
        {
            addTeacher_bttn.BackColor = Color.Transparent;
        }

        private void addBranch_bttn_MouseEnter(object sender, EventArgs e)
        {
            addBranch_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void addBranch_bttn_MouseLeave(object sender, EventArgs e)
        {
            addBranch_bttn.BackColor = Color.Transparent;
        }

        private void studentAdd_bttn_MouseEnter(object sender, EventArgs e)
        {
            studentAdd_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void studentAdd_bttn_MouseLeave(object sender, EventArgs e)
        {
            studentAdd_bttn.BackColor = Color.Transparent;
        }

        private void addCourse_bttn_MouseEnter(object sender, EventArgs e)
        {
            addCourse_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void addCourse_bttn_MouseLeave(object sender, EventArgs e)
        {
            addCourse_bttn.BackColor = Color.Transparent;
        }

        private void viewCourse_bttn_MouseEnter(object sender, EventArgs e)
        {
            viewCourse_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void viewCourse_bttn_MouseLeave(object sender, EventArgs e)
        {
            viewCourse_bttn.BackColor = Color.Transparent;
        }

        private void updateCourse_bttn_MouseEnter(object sender, EventArgs e)
        {
            updateCourse_bttn.BackColor = Color.DarkSeaGreen;
        }

        private void updateCourse_bttn_MouseLeave(object sender, EventArgs e)
        {
            updateCourse_bttn.BackColor = Color.Transparent;
        }
        void load_branch()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branch", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            branch_combobox.DataSource = dt;
            branch_combobox.ValueMember = "BranchID";
            branch_combobox.DisplayMember = "BranchName";
            branch_combobox.SelectedIndex = -1;
        }
        void load_teachers()
        {
            if (branch_combobox.SelectedValue != null && int.TryParse(branch_combobox.SelectedValue.ToString(), out int branchId))
            {
                int branchID = Convert.ToInt32(branch_combobox.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter("select TeacherID,(Name + ' ' + Surname) as Teacher from Tbl_Teacher \r\ninner join Tbl_Branch\r\non Tbl_Teacher.BranchID = Tbl_Branch.BranchID \r\nwhere Tbl_Teacher.BranchID= @p1", conn);
                da.SelectCommand.Parameters.AddWithValue("@p1",branchID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                teacher_combobox.DataSource = dt;
                teacher_combobox.ValueMember = "TeacherID";
                teacher_combobox.DisplayMember = "Teacher";
                teacher_combobox.SelectedIndex = -1;
            }
        }
        void load_teacher_branches()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select BranchID,BranchName from Tbl_Branch", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            teacherBranch_combobox.DataSource = dt;
            teacherBranch_combobox.ValueMember = "BranchID";
            teacherBranch_combobox.DisplayMember = "BranchName";
            teacherBranch_combobox.SelectedIndex = -1;
        }
        void load_students()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select StudentID, (Name + ' ' + Surname) as Full_Name from Tbl_Student", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            student_combobox.DataSource = dt;
            student_combobox.ValueMember = "StudentID";
            student_combobox.DisplayMember = "Full_Name";
            student_combobox.SelectedIndex = -1;
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataGridView1.TabStop = false;
            load_branch();
            load_teacher_branches();
            load_students();
        }

        private void addCourse_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Course (BranchID,TeacherID,StudentID,Date,Time,Status) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", branch_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", teacher_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", student_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p4", date_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", time_txtbox.Text);
            if(status_bttn.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p6", "True");
            }
            else
            {
                cmd.Parameters.AddWithValue("@p6", "False");
            }
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New course is added.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clean_course();
        }
        void view_course()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID,Tbl_Branch.BranchName,(Tbl_Teacher.Name + ' ' + Tbl_Teacher.Surname) as Teacher, (Tbl_Student.Name+' '+Tbl_Student.Surname) as Student,Date,Time,Status from Tbl_Course\r\ninner join Tbl_Branch \r\non Tbl_Course.BranchID = Tbl_Branch.BranchID\r\ninner join Tbl_Teacher\r\non Tbl_Course.TeacherID = Tbl_Teacher.TeacherID\r\ninner join Tbl_Student\r\non Tbl_Course.StudentID = Tbl_Student.StudentID", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void viewCourse_bttn_Click(object sender, EventArgs e)
        {
            view_course();
        }

        private void branch_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_teachers();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = dataGridView1.SelectedCells[0].RowIndex;
            id_txtbox.Text = dataGridView1.Rows[no].Cells[0].Value.ToString();
            branch_combobox.Text = dataGridView1.Rows[no].Cells[1].Value.ToString();
            teacher_combobox.Text = dataGridView1.Rows[no].Cells[2].Value.ToString();
            student_combobox.Text = dataGridView1.Rows[no].Cells[3].Value.ToString();
            date_txtbox.Text = dataGridView1.Rows[no].Cells[4].Value.ToString();
            time_txtbox.Text = dataGridView1.Rows[no].Cells[5].Value.ToString();
            if (dataGridView1.Rows[no].Cells[6].Value is bool status)
            {
                status_bttn.Checked = status;
            }
            else
            {
                status_bttn.Checked = false;
            }
            
        }

        private void updateCourse_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Course set BranchID = @p1,TeacherID = @p2,StudentID = @p3,Date = @p4,Time = @p5,Status = @p6 where ID = @p7", conn);
            cmd.Parameters.AddWithValue("@p1", branch_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", teacher_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", student_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p4", date_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", time_txtbox.Text);
            if(status_bttn.Checked)
            {
                cmd.Parameters.AddWithValue("@p6",true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p6", false);
            }
            cmd.Parameters.AddWithValue("@p7", id_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Information is updated.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            view_course();
            clean_course();
        }

        private void addBranch_bttn_Click(object sender, EventArgs e)
        {
            if(branchName_txtbox.Text == null)
            {
                MessageBox.Show("Fill the blank.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from Tbl_Branch where BranchName = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", branchName_txtbox.Text);
                int courseExists = (int)cmd.ExecuteScalar();
                if (courseExists > 0)
                {
                    MessageBox.Show("This branch already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into Tbl_Branch (BranchName) values (@p1)", conn);
                    cmd1.Parameters.AddWithValue("@p1", branchName_txtbox.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("New branch is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_branch();
                    load_teacher_branches();
                    branchName_txtbox.Text = "";
                }
                conn.Close();
            }
            
        }
        public int GenerateUniqueTeacherNumber(SqlConnection conn)
        {
            Random rnd = new Random();
            int randomNumber;
            bool isUnique = false;

            do
            {
                randomNumber = rnd.Next(100, 1000);

                string query = "SELECT COUNT(*) FROM Tbl_Teacher WHERE TeacherNumber = @p1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", randomNumber);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        isUnique = true;
                    }
                }
            } while (!isUnique);
            return randomNumber;
        }
        private void addTeacher_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int teacher_no = GenerateUniqueTeacherNumber(conn);
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Teacher (Name,Surname,BranchID,Password,TeacherNumber) values (@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1", teacherName_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", teacherSurname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", teacherBranch_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p4", teacherPassword_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", teacher_no);
            cmd.ExecuteNonQuery();
            teacherNumber_txtbox.Text = teacher_no.ToString();
            conn.Close();
            MessageBox.Show("New teacher is added.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            clean_teacher();
        }
        public int GenerateUniqueStudentNumber(SqlConnection conn)
        {
            Random rnd = new Random();
            int randomNumber;
            bool isUnique = false;

            do
            {
                randomNumber = rnd.Next(100, 1000);

                string query = "SELECT COUNT(*) FROM Tbl_Student WHERE StudentNumber = @p1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", randomNumber);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        isUnique = true;
                    }
                }
            } while (!isUnique);
            return randomNumber;
        }
        private void studentAdd_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int student_no = GenerateUniqueStudentNumber(conn);
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Student (Name,Surname,Class,Phone,Mail,Password,StudentNumber) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
            cmd.Parameters.AddWithValue("@p1", studentName_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", studentSurname_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", studentClass_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", studentPhone_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", studentMail_txtbox.Text);
            cmd.Parameters.AddWithValue("@p6", studentPassword_txtbox.Text);
            cmd.Parameters.AddWithValue("@p7", student_no);
            studentNumber_txtbox.Text = student_no.ToString();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New student is added.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            load_students();
            clean_student();
        }
        void clean_course()
        {
            id_txtbox.Text = "";
            branch_combobox.SelectedItem = null;
            teacher_combobox.SelectedItem = null;
            student_combobox.SelectedItem = null;
            date_txtbox.Text = "";
            time_txtbox.Text = "";
            status_bttn.Checked = false;
        }
        void clean_teacher()
        {
            teacherName_txtbox.Text = "";
            teacherSurname_txtbox.Text = "";
            teacherBranch_combobox.SelectedItem = null;
            teacherPassword_txtbox.Text = "";
            teacherNumber_txtbox.Text = "";
        }
        void clean_student()
        {
            studentName_txtbox.Text = "";
            studentSurname_txtbox.Text = "";
            studentClass_txtbox.Text = "";
            studentPhone_txtbox.Text = "";
            studentMail_txtbox.Text = "";
            studentPassword_txtbox.Text = "";
            studentNumber_txtbox.Text = "";
        }
    }
}
