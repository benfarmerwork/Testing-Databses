using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetStudentForCourseTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studentTableAdapter = new Learning_databasesDataSetTableAdapters.StudentsTableAdapter();
            var studentsTable = studentTableAdapter.GetDataByCourseId(2);

            StringBuilder allNames = new StringBuilder();

            // Loop through each returned student row and add name/second name to string
            foreach(var studentRow in studentsTable.Rows.Cast<Learning_databasesDataSet.StudentsRow>())
            {
                allNames.AppendLine(studentRow.Name + " " + studentRow.SecondName);
            }

            MessageBox.Show(allNames.ToString());
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            var courseAdapter = new Learning_databasesDataSetTableAdapters.CoursesTableAdapter();
            var courseTable = courseAdapter.GetData();

            StringBuilder allClasses = new StringBuilder();

            // Loop through each returned student row and add name/second name to string
            foreach (var coursesRow in courseTable.Rows.Cast<Learning_databasesDataSet.CoursesRow>())
            {
                allClasses.AppendLine(coursesRow.Description );
            }

            MessageBox.Show(allClasses.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'learning_databasesDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.learning_databasesDataSet.Courses);
            // TODO: This line of code loads data into the 'learning_databasesDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.learning_databasesDataSet.Rooms);
            // TODO: This line of code loads data into the 'learning_databasesDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.learning_databasesDataSet.Students);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var studentTableAdapter = new Learning_databasesDataSetTableAdapters.StudentsTableAdapter();
            var studentsTable = studentTableAdapter.GetDataByStudentSecondName(textBox1.Text);
            StringBuilder allNames = new StringBuilder();

            // Loop through each returned student row and add name/second name to string
            foreach (var studentRow in studentsTable.Rows.Cast<Learning_databasesDataSet.StudentsRow>())
            {
                allNames.AppendLine(studentRow.Name + " " + studentRow.SecondName);
            }

            MessageBox.Show(allNames.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var studentTableAdapter = new Learning_databasesDataSetTableAdapters.StudentsTableAdapter();
            var studentsTable = studentTableAdapter.InsertStudent(FirstName.Text, SecondName.Text, int.Parse(Age.Text), Gender.Text, int.Parse(CourseId.Text));
            this.studentsTableAdapter.Fill(this.learning_databasesDataSet.Students);
        }

        private void learningdatabasesDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var CoursesTableAdapter = new Learning_databasesDataSetTableAdapters.CoursesTableAdapter();
            var courseId = (int)CoursesTableAdapter.InsertCourse(CourseName.Text,int.Parse(CourseLength.Text), int.Parse(RoomName.Text));
            MessageBox.Show(courseId.ToString()); 
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataRowView dataViewRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                Learning_databasesDataSet.StudentsRow studentRow
                    = (Learning_databasesDataSet.StudentsRow)dataViewRow.Row;
                var studentId = studentRow.Id;
                var result = MessageBox.Show("Are you sure you want to delete student " + studentRow.Name + " " + studentRow.SecondName,"Delete Student",MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var StudentsTableAdapter = new Learning_databasesDataSetTableAdapters.StudentsTableAdapter();
                    StudentsTableAdapter.DeleteStudent(studentId);
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
            }
            else
                MessageBox.Show("No student selected");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            var RoomTableAdapter = new Learning_databasesDataSetTableAdapters.RoomsTableAdapter();
            var RoomId = RoomTableAdapter.DeleteRoom(int.Parse(DeleteRoomtxt.Text));
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var RoomsTableAdapter = new Learning_databasesDataSetTableAdapters.RoomsTableAdapter();
            var courseId = (int)RoomsTableAdapter.InsertRoom(RoomName.Text, int.Parse(NumberOfStudentstxt.Text));
            MessageBox.Show(courseId.ToString());
        }
    }
}
