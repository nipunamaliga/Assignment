using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentRegistration
{
    public partial class NewStudentData : Form
    {
        public NewStudentData()
        {
            InitializeComponent();
        }

        private void newDetails_Click(object sender, EventArgs e)
        {
            try
            {
                stdGPA.Clear();
                stbDOB.Value = DateTime.Now;
                stdNameValue.Clear();
                stdStatus.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Student Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NewStudentData_Load(object sender, EventArgs e)
        {
            stdID.Text = StudentData.nextId.ToString();
        }

        private void saveDetails_Click(object sender, EventArgs e)
        {
            DataTable ndt = new DataTable();
            ndt.Columns.AddRange(new DataColumn[] { new DataColumn("Student ID", typeof(string)), new DataColumn("Student Name", typeof(string)), new DataColumn("Date of Birth", typeof(DateTime)), new DataColumn("GPA", typeof(string)), new DataColumn("Status", typeof(bool)) });
            ndt.Rows.Add(new object[] { stdID.Text,stdNameValue.Text,stbDOB.Value,stdGPA.Text,stdStatus.Checked });
            StudentData.newValues = ndt;
            this.Close();
            StudentDetails detail = new StudentDetails();
            detail.Show();
            detail.MdiParent = Application.OpenForms["Registrations"];
        }

        private void stdGPA_Validated(object sender, EventArgs e)
        {
            decimal value = 0;
            if(!Decimal.TryParse(stdGPA.Text,out value))
                MessageBox.Show("GPA Value Is Not Valid", "Student Registrations", MessageBoxButtons.OK, MessageBoxIcon.Error);

            stdGPA.Text = "0.00";
        }
    }
}
