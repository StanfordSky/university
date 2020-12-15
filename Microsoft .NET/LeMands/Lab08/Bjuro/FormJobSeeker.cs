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
        private JobSeeker _jobSeeker;
        public JobSeeker JobSeeker 
        {
            get 
            {
                return _jobSeeker;
            }
            set 
            {
                _jobSeeker = value;
                textBoxFirstName.Text = _jobSeeker.FirstName;
                textBoxMiddleName.Text = _jobSeeker.MiddleName;
                textBoxLastName.Text = _jobSeeker.LastName;
                textBoxQualification.Text = _jobSeeker.Qualification;
                textBoxKindOfActivity.Text = _jobSeeker.KindOfActivity;
                textBoxNumber.Text = _jobSeeker.Passport.Number;
                textBoxSeria.Text = _jobSeeker.Passport.Seria;
                dateTimePickerDate.Value = _jobSeeker.Passport.Date;
                textBoxIssuer.Text = _jobSeeker.Passport.Issuer;
                textBoxSalary.Text = _jobSeeker.Salary;
            }
        }
        public FormJobSeeker()
        {
            InitializeComponent();
        }

        private void JobSeeker_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _jobSeeker.FirstName = textBoxFirstName.Text;
            _jobSeeker.MiddleName = textBoxMiddleName.Text;
            _jobSeeker.LastName = textBoxLastName.Text;
            _jobSeeker.Qualification = textBoxQualification.Text;
            _jobSeeker.KindOfActivity = textBoxKindOfActivity.Text;
            _jobSeeker.Passport.Number = textBoxNumber.Text;
            _jobSeeker.Passport.Seria = textBoxSeria.Text;
            _jobSeeker.Passport.Date = dateTimePickerDate.Value;
            _jobSeeker.Passport.Issuer = textBoxIssuer.Text;
            _jobSeeker.Salary = textBoxSalary.Text;

        }
    }
}
