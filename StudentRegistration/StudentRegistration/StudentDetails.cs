using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegistration
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
            DataTable dt = StudentData.newValues;
            if (StudentData.oldValues != null)
                dt.Merge(StudentData.oldValues);
            dataToSave.DataSource = dt;
        }

        private void NewRgistration_Click(object sender, EventArgs e)
        {
            StudentData.oldValues = (DataTable)dataToSave.DataSource;
            DBHandler handler = new DBHandler();
            int count = StudentData.oldValues == null ? 0 : StudentData.oldValues.Rows.Count;
            StudentData.nextId = handler.GetNextNo("studentid", "students")+count;
            this.Close();
            NewStudentData student = new NewStudentData();
            student.Show();
            student.MdiParent = Application.OpenForms["Registrations"];
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void saveData_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataToSave.DataSource;
            DBHandler handler = new DBHandler();
            foreach (DataRow row in dt.Rows)
            {
                handler.CallSp("saveData", new System.Data.SqlClient.SqlParameter[]
                {
                    new System.Data.SqlClient.SqlParameter("@stdName",Convert.ToString(row["Student Name"])),
                    new System.Data.SqlClient.SqlParameter("@stddob",Convert.ToDateTime(row["Date of Birth"])),
                    new System.Data.SqlClient.SqlParameter("@stdgpa",Convert.ToDecimal(row["GPA"])),
                    new System.Data.SqlClient.SqlParameter("@stdstatus",Convert.ToBoolean(row["Status"])),
                });
            }

            MessageBox.Show("Successfully Saved", "Student Registrations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(StudentData.oldValues != null)
            StudentData.oldValues.Clear();
            if (StudentData.newValues != null)
            StudentData.newValues.Clear();
        }
    }
}
