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
    public partial class FormMain : Form
    {
        //private Employers _employer;
        //private JobSeekers _jobSeeker;
        //private Dealings _dealings; 
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employer = new Employer();
            FormEmployer formEmployer = new FormEmployer(employer);
            if (formEmployer.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgency.Employers.Add(employer.EmployerId, employer);
                UpdateEmployersList();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employer = listViewEmployers.SelectedItems[0].Tag as Employer;
            FormEmployer formEmployer = new FormEmployer(employer);
            if (formEmployer.ShowDialog() == DialogResult.OK)
            {
                UpdateEmployersList();
            }
        }

        private void UpdateEmployersList()
        {
            listViewEmployers.Items.Clear();
            foreach (var item in EmploymentAgency.Employers)
            {
                var employer = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = employer,
                    Text = employer.ToString()
                };
                listViewEmployers.Items.Add(listViewItem);
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var jobSeeker = new JobSeeker();
            FormJobSeeker formJobSeeker = new FormJobSeeker(jobSeeker);
            if (formJobSeeker.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgency.JobSeekers.Add(jobSeeker.Number, jobSeeker);
                UpdateJobSeekersList();
            }
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var jobSeeker = listViewJobSeekers.SelectedItems[0].Tag as JobSeeker;
            FormJobSeeker formJobSeeker = new FormJobSeeker(jobSeeker);
            if (formJobSeeker.ShowDialog() == DialogResult.OK)
            {
                UpdateJobSeekersList();
            }
        }

        private void UpdateJobSeekersList()
        {
            listViewJobSeekers.Items.Clear();
            foreach (var item in EmploymentAgency.JobSeekers)
            {
                var jobSeeker = item.Value;
                var listViewItem = new ListViewItem
                {
                    Tag = jobSeeker,
                    Text = jobSeeker.ToString()
                };
                listViewJobSeekers.Items.Add(listViewItem);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItemDealings_Click(object sender, EventArgs e)
        {
            var dealing = new Dealing();
            FormDealing formDealings = new FormDealing(dealing);
            if (formDealings.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgency.Dealings.Add(dealing);
                UpdateDealingsList();
            }
        }

        private void редактироватьToolStripMenuItemDealings_Click(object sender, EventArgs e)
        {
            var dealing = listViewDealings.SelectedItems[0].Tag as Dealing;
            FormDealing formDealings = new FormDealing(dealing);
            if (formDealings.ShowDialog() == DialogResult.OK)
            {
                UpdateDealingsList();
            }
        }

        private void UpdateDealingsList()
        {
            listViewDealings.Items.Clear();
            foreach (var dealing in EmploymentAgency.Dealings)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = dealing,
                    Text = dealing.Employer.ToString()
                };
                listViewItem.SubItems.Add(dealing.Employer.ToString());
                listViewItem.SubItems.Add(dealing.Post.ToString());
                listViewItem.SubItems.Add(dealing.Commission.ToString());
                listViewDealings.Items.Add(listViewItem);
            }
        }
    }
}
