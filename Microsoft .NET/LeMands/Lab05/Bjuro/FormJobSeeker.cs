using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBjuro;

namespace Bjuro
{
    public partial class FormJobSeeker : Form
    {
        public JobSeeker JobSeeker { get; }
        public FormJobSeeker(JobSeeker jobSeeker)
        {
            InitializeComponent();
            JobSeeker = jobSeeker;
            textBoxFirstName.Text = JobSeeker.FirstName;
            textBoxMiddleName.Text = JobSeeker.MiddleName;
            textBoxLastName.Text = JobSeeker.LastName;
            textBoxQualification.Text = JobSeeker.Qualification;
            textBoxKindOfActivity.Text = JobSeeker.KindOfActivity;
            textBoxNumber.Text = JobSeeker.Passport.Number;
            textBoxSeria.Text = JobSeeker.Passport.Seria;
            dateTimePickerDate.Value = JobSeeker.Passport.Date;
            textBoxIssuer.Text = JobSeeker.Passport.Issuer;
            textBoxSalary.Text = JobSeeker.Salary;

        }

        private void JobSeeker_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            JobSeeker.FirstName = textBoxFirstName.Text;
            JobSeeker.MiddleName = textBoxMiddleName.Text;
            JobSeeker.LastName = textBoxLastName.Text;
            JobSeeker.Qualification = textBoxQualification.Text;
            JobSeeker.KindOfActivity = textBoxKindOfActivity.Text;
            JobSeeker.Passport.Number = textBoxNumber.Text;
            JobSeeker.Passport.Seria = textBoxSeria.Text;
            JobSeeker.Passport.Date = dateTimePickerDate.Value;
            JobSeeker.Passport.Issuer = textBoxIssuer.Text;
            JobSeeker.Salary = textBoxSalary.Text;

        }
    }
}
