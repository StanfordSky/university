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
    public partial class FormDealing : Form
    {
        private Dealing _dealing;
        public Dealing Dealing 
        {
            get 
            {
                return _dealing;
            }
            set 
            {
                _dealing = value;
                comboBoxEmployer.SelectedItem = _dealing.Employer;
                comboBoxJobSeeker.SelectedItem = _dealing.JobSeeker;
                textBoxPost.Text = _dealing.Post;
                textBoxCommission.Text = _dealing.Commission;
            }
        }
        private readonly EmploymentAgency _employmentAgency = EmploymentAgency.Instance;
        public FormDealing()
        {
            InitializeComponent();
            _employmentAgency.EmployerAdded += _employmentAgency_EmployerAdded;
            _employmentAgency.EmployerRemoved += _employmentAgency_EmployerRemoved;
            _employmentAgency.JobSeekerAdded += _employmentAgency_JobSeekerAdded;
            _employmentAgency.JobSeekerRemoved += _employmentAgency_JobSeekerRemoved;
            foreach (var employer in _employmentAgency.Employers)
            {
                comboBoxEmployer.Items.Add(employer);
            }
            foreach (var jobSeeker in _employmentAgency.JobSeekers)
            {
                comboBoxJobSeeker.Items.Add(jobSeeker);
            }
        }

        private void _employmentAgency_JobSeekerRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxJobSeeker.Items.Count; i++)
            {
                var jobSeeker = comboBoxJobSeeker.Items[i] as JobSeeker;
                if (jobSeeker?.Number == key)
                {
                    comboBoxJobSeeker.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _employmentAgency_JobSeekerAdded(object sender, EventArgs e)
        {
            comboBoxJobSeeker.Items.Add(sender);
        }

        private void _employmentAgency_EmployerRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxEmployer.Items.Count; i++)
            {
                var employer = comboBoxEmployer.Items[i] as Employer;
                if (employer?.EmployerId == key)
                {
                    comboBoxEmployer.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _employmentAgency_EmployerAdded(object sender, EventArgs e)
        {
            comboBoxEmployer.Items.Add(sender);
        }

        private void FormDealings_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _dealing.Employer = comboBoxEmployer.SelectedItem as Employer;
            _dealing.JobSeeker = comboBoxJobSeeker.SelectedItem as JobSeeker;
            _dealing.Post = textBoxPost.Text;
            _dealing.Commission = textBoxCommission.Text;
        }
    }
}
