using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
  

        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CONFIRM");
            this.Close();
        }
       

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            StudentInformationClass studentInformationClass = new StudentInformationClass();
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblGender.Text =StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();

        }

        private void lblStudent_Click(object sender, EventArgs e)
        {

        }
    }
}