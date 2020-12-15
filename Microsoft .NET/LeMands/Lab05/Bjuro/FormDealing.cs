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
        public Dealing Dealing { get; }
        public FormDealing(Dealing dealing)
        {
            InitializeComponent();
            Dealing = dealing;
            foreach (var item in EmploymentAgency.Employers)
            {
                var employer = item.Value;
                comboBoxEmployer.Items.Add(employer);
            }
            foreach (var item in EmploymentAgency.JobSeekers)
            {
                var jobSeeker = item.Value;
                comboBoxJobSeeker.Items.Add(jobSeeker);
            }
            comboBoxEmployer.SelectedItem = dealing.Employer;
            comboBoxJobSeeker.SelectedItem = dealing.JobSeeker;
            textBoxPost.Text = dealing.Post;
            textBoxCommission.Text = dealing.Commission;
        }

        private void FormDealings_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Dealing.Employer = comboBoxEmployer.SelectedItem as Employer;
            Dealing.JobSeeker = comboBoxJobSeeker.SelectedItem as JobSeeker;
            Dealing.Post = textBoxPost.Text;
            Dealing.Commission = textBoxCommission.Text;
        }
    }
}
