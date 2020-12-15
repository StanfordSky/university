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
using WindowsFormsControlLibraryBjuro;
using ClassLibraryBjuro.Serialization;

namespace Bjuro
{
    public partial class FormMain : Form
    {
        private readonly EmploymentAgency _employmentAgency = EmploymentAgency.Instance;
        readonly FormEmployer _formEmployer = new FormEmployer();
        readonly FormJobSeeker _formJobSeeker = new FormJobSeeker();
        readonly FormDealing _formDealing = new FormDealing();

        public FormMain()
        {
            InitializeComponent();
            _employmentAgency.EmployerAdded += _employmentAgency_EmployerAdded;
            _employmentAgency.JobSeekerAdded += _employmentAgency_JobSeekerAdded;
            _employmentAgency.DealingAdded += _employmentAgency_DealingAdded;
            _employmentAgency.EmployerRemoved += _employmentAgency_EmployerRemoved;
            _employmentAgency.JobSeekerRemoved += _employmentAgency_JobSeekerRemoved;
            _employmentAgency.DealingRemoved += _employmentAgency_DealingRemoved;
        }

        private void _employmentAgency_DealingRemoved(object sender, EventArgs e)
        {
            var dealing = sender as Dealing;
            for (int i = 0; i < tabPageDealings.Controls.Count; i++)
            {
                if ((tabPageDealings.Controls[i] as UserControlDealing)?.Dealing == dealing)
                {
                    tabPageDealings.Controls.RemoveAt(i);
                    break;
                }
            }
        }

        private void _employmentAgency_JobSeekerRemoved(object sender, EventArgs e)
        {
            var jobSeekerNumber = (int)sender;
            for (int i = 0; i < listViewJobSeekers.Items.Count; i++)
            {
                if (((JobSeeker)listViewJobSeekers.Items[i].Tag).Number == jobSeekerNumber)
                {
                    listViewJobSeekers.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _employmentAgency_EmployerRemoved(object sender, EventArgs e)
        {
            var emplyerId = (int)sender;
            for (int i = 0; i < listViewEmployers.Items.Count; i++)
            {
                if (((Employer)listViewEmployers.Items[i].Tag).EmployerId == emplyerId)
                {
                    listViewEmployers.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _employmentAgency_DealingAdded(object sender, EventArgs e)
        {
            var dealing = sender as Dealing;
            if (dealing != null)
            {
                UserControlDealing userControl = new UserControlDealing(dealing)
                {
                    Dock = DockStyle.Top
                }; tabPageDealings.Controls.Add(userControl);
            }

        }

        private void _employmentAgency_JobSeekerAdded(object sender, EventArgs e)
        {
            var jobSeeker = sender as JobSeeker;
            if (jobSeeker != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = jobSeeker,
                    Text = jobSeeker.ToString()
                };
                listViewJobSeekers.Items.Add(listViewItem);
            }
        }

        private void _employmentAgency_EmployerAdded(object sender, EventArgs e)
        {
            var emplyer = sender as Employer;
            if (emplyer != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = emplyer,
                    Text = emplyer.ToString()
                };
                listViewEmployers.Items.Add(listViewItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employer = new Employer();
            _formEmployer.Employer = employer;
            if (_formEmployer.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _employmentAgency.AddEmployer(employer);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var employer = listViewEmployers.SelectedItems[0].Tag as Employer;
                _formEmployer.Employer = employer;
                if (_formEmployer.ShowDialog() == DialogResult.OK)
                {
                    listViewEmployers.SelectedItems[0].Text = _formEmployer.Employer.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с работодателем");
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var jobSeeker = new JobSeeker();
            _formJobSeeker.JobSeeker = jobSeeker;
            if (_formJobSeeker.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _employmentAgency.AddJobSeeker(jobSeeker);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var jobSeeker = listViewJobSeekers.SelectedItems[0].Tag as JobSeeker;
                _formJobSeeker.JobSeeker = jobSeeker;
                if (_formJobSeeker.ShowDialog() == DialogResult.OK)
                {
                    listViewJobSeekers.SelectedItems[0].Text = _formJobSeeker.JobSeeker.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с соискателем");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItemDealings_Click(object sender, EventArgs e)
        {
            var dealing = new Dealing();
            _formDealing.Dealing = dealing;
            if (_formDealing.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _employmentAgency.AddDealing(dealing);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void редактироватьToolStripMenuItemDealings_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tabPageDealings.Controls.Count; i++)
                {
                    var userControl = tabPageDealings.Controls[i] as UserControlDealing;
                    if (userControl != null)
                    {
                        if (userControl.Selected)
                        {
                            var dealing = userControl.Dealing;
                            _formDealing.Dealing = dealing;
                            if (_formDealing.ShowDialog() == DialogResult.OK)
                            {
                                userControl.Refresh();
                            }
                            break;
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка со сделкой");
            }
        }

        private void listViewEmployers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var employer = listViewEmployers.SelectedItems[0].Tag as Employer;
                    if (employer != null)
                    {
                        _employmentAgency.RemoveEmployer(employer.EmployerId);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с работодателем");
                }
            }
        }

        private void listViewJobSeekers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var jobSeeker = listViewJobSeekers.SelectedItems[0].Tag as JobSeeker;
                    if (jobSeeker != null)
                    {
                        _employmentAgency.RemoveJobSeeker(jobSeeker.Number);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Не выбрана строка с соискателем");
                }
            }
        }

        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.Filter = "XML-файлы|*.xml|Все файлы|*.*";
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgencySerializable.Save(saveFileDialogMain.FileName, SerializeType.XML);
            }
        }

        private void saveJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.Filter = "JSON-файлы|*.json|Все файлы|*.*";
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgencySerializable.Save(saveFileDialogMain.FileName, SerializeType.JSON);
            }
        }

        private void saveBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.Filter = "Двоичные файлы|*.bin|Все файлы|*.*";
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgencySerializable.Save(saveFileDialogMain.FileName, SerializeType.Binary);
            }
        }

        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogMain.Filter = "XML-файлы|*.xml|Все файлы|*.*";
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgencySerializable.Load(openFileDialogMain.FileName, SerializeType.XML);

            }
        }

        private void loadJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogMain.Filter = "JSON-файлы|*.json|Все файлы|*.*";
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgencySerializable.Load(openFileDialogMain.FileName, SerializeType.JSON);
            }
        }

        private void loadBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogMain.Filter = "Двоичные файлы|*.bin|Все файлы|*.*";
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                EmploymentAgencySerializable.Load(openFileDialogMain.FileName, SerializeType.Binary);
            }
        }
    }
}
