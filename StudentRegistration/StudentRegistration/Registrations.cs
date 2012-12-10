using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Registrations : Form
    {
        public Registrations()
        {
            InitializeComponent();
        }

        private void exittem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            StudentDetails data = new StudentDetails();
            data.MdiParent = this;
            data.Show();
        }


    }
}
