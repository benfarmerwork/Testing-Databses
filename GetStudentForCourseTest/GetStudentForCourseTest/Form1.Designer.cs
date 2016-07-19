namespace GetStudentForCourseTest
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.CourseId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.CourseLength = new System.Windows.Forms.TextBox();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteRoomtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.NumberOfStudentstxt = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learningdatabasesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learning_databasesDataSet = new GetStudentForCourseTest.Learning_databasesDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new GetStudentForCourseTest.Learning_databasesDataSetTableAdapters.TableAdapterManager();
            this.studentsTableAdapter = new GetStudentForCourseTest.Learning_databasesDataSetTableAdapters.StudentsTableAdapter();
            this.roomsTableAdapter = new GetStudentForCourseTest.Learning_databasesDataSetTableAdapters.RoomsTableAdapter();
            this.coursesTableAdapter = new GetStudentForCourseTest.Learning_databasesDataSetTableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningdatabasesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learning_databasesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(93, 12);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(75, 23);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(12, 87);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(75, 20);
            this.FirstName.TabIndex = 4;
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(94, 87);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(75, 20);
            this.SecondName.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(175, 87);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(75, 20);
            this.Age.TabIndex = 6;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(256, 87);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(75, 20);
            this.Gender.TabIndex = 7;
            // 
            // CourseId
            // 
            this.CourseId.Location = new System.Drawing.Point(337, 87);
            this.CourseId.Name = "CourseId";
            this.CourseId.Size = new System.Drawing.Size(75, 20);
            this.CourseId.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Second Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Course ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Course Length";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Description";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RoomName
            // 
            this.RoomName.Location = new System.Drawing.Point(175, 129);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(75, 20);
            this.RoomName.TabIndex = 17;
            // 
            // CourseLength
            // 
            this.CourseLength.Location = new System.Drawing.Point(94, 129);
            this.CourseLength.Name = "CourseLength";
            this.CourseLength.Size = new System.Drawing.Size(75, 20);
            this.CourseLength.TabIndex = 16;
            // 
            // CourseName
            // 
            this.CourseName.Location = new System.Drawing.Point(12, 129);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(75, 20);
            this.CourseName.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Delete";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(715, 232);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteRoomtxt
            // 
            this.DeleteRoomtxt.Location = new System.Drawing.Point(12, 617);
            this.DeleteRoomtxt.Name = "DeleteRoomtxt";
            this.DeleteRoomtxt.Size = new System.Drawing.Size(238, 20);
            this.DeleteRoomtxt.TabIndex = 24;
            this.DeleteRoomtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.courseIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 193);
            this.dataGridView1.TabIndex = 29;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.learningdatabasesDataSetBindingSource;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(611, 613);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRoom.TabIndex = 30;
            this.btnDeleteRoom.Text = "DeleteRow";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.roomNameDataGridViewTextBoxColumn,
            this.numberOfStudentsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.roomsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 445);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(679, 150);
            this.dataGridView2.TabIndex = 31;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.learningdatabasesDataSetBindingSource;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.learningdatabasesDataSetBindingSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Number Of Students";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Room Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NumberOfStudentstxt
            // 
            this.NumberOfStudentstxt.Location = new System.Drawing.Point(94, 176);
            this.NumberOfStudentstxt.Name = "NumberOfStudentstxt";
            this.NumberOfStudentstxt.Size = new System.Drawing.Size(107, 20);
            this.NumberOfStudentstxt.TabIndex = 33;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 176);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(75, 20);
            this.NameTextBox.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // numberOfStudentsDataGridViewTextBoxColumn
            // 
            this.numberOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfStudents";
            this.numberOfStudentsDataGridViewTextBoxColumn.HeaderText = "NumberOfStudents";
            this.numberOfStudentsDataGridViewTextBoxColumn.Name = "numberOfStudentsDataGridViewTextBoxColumn";
            // 
            // learningdatabasesDataSetBindingSource
            // 
            this.learningdatabasesDataSetBindingSource.DataSource = this.learning_databasesDataSet;
            this.learningdatabasesDataSetBindingSource.Position = 0;
            this.learningdatabasesDataSetBindingSource.CurrentChanged += new System.EventHandler(this.learningdatabasesDataSetBindingSource_CurrentChanged);
            // 
            // learning_databasesDataSet
            // 
            this.learning_databasesDataSet.DataSetName = "Learning_databasesDataSet";
            this.learning_databasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GetStudentForCourseTest.Learning_databasesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.NumberOfStudentstxt);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteRoomtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.CourseLength);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CourseId);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningdatabasesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learning_databasesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Learning_databasesDataSet learning_databasesDataSet;
        private Learning_databasesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox CourseId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource learningdatabasesDataSetBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.TextBox CourseLength;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DeleteRoomtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Learning_databasesDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private Learning_databasesDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private Learning_databasesDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox NumberOfStudentstxt;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

