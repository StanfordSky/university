using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryWork;
using System.Windows.Forms;

namespace _4_2
{
    public partial class MainMenu : Form
    {

        private readonly Human _human = Human.Instance; 
        readonly FormEmployee _formEmployee = new FormEmployee(); 
        readonly FormTypeOfWork _formTypeOfWork = new FormTypeOfWork(); 
        readonly FormJob _formJob = new FormJob();

        public MainMenu()
        {
            InitializeComponent();
            _human.EmployeeAdded     += _human_EmployeeAdded;
            _human.EmployeeRemoved   += _human_EmployeeRemoved;

            _human.TypeOfWorkAdded   += _human_TypeOfWorkAdded;
            _human.TypeOfWorkRemoved += _human_TypeOfWorkRemoved;

            _human.JobRemoved        += _human_JobAdded;
            _human.JobRemoved        += _human_JobRemoved;

        }

        private void _human_JobRemoved(object sender, EventArgs e)
        {
            var job = sender as Job; 
            for (int i = 0; i < listViewJob.Items.Count; i++)
            {
                if ((Job)listViewJob.Items[i].Tag == job)
                {
                    listViewJob.Items.RemoveAt(i); 
                    break;
                }
            }
        }

        private void _human_TypeOfWorkRemoved(object sender, EventArgs e)
        {
            var typeOfWorkId = (int)sender;
            for (int i = 0; i < listViewTypeOfWork.Items.Count; i++)
            {
                if(((TypeOfWork)listViewTypeOfWork.Items[i].Tag).TypeOfWorkId == typeOfWorkId)
                {
                    listViewTypeOfWork.Items.RemoveAt(i); 
                    break;
                }
            }
        }

        private void _human_EmployeeRemoved(object sender, EventArgs e)
        {
            var employeeId = (int)sender;
            for (int i = 0; i < listViewEmployee.Items.Count; i++)
            {
                if(((Employee)listViewEmployee.Items[i].Tag).EmployeeId == employeeId)
                {
                    listViewEmployee.Items.RemoveAt(i); 
                    break;
                }
            }
        }

        private void _human_JobAdded(object sender, EventArgs e)
        {
            var job = sender as Job;
            if (job != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = job,
                    Text = job.Worker.ToString()
                };

                listViewItem.SubItems.Add(job.Position.ToString());
                listViewJob.Items.Add(listViewItem);
            }
        }

        private void _human_TypeOfWorkAdded(object sender, EventArgs e)
        {
            var typeOfWork = sender as TypeOfWork;
            if (typeOfWork != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = typeOfWork,
                    Text = typeOfWork.ToString()
                };
                listViewTypeOfWork.Items.Add(listViewItem);
            }
        }

        private void _human_EmployeeAdded(object sender, EventArgs e)
        {
            var employee = sender as Employee;
            if (employee != null)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = employee,
                    Text = employee.ToString()
                };

                listViewEmployee.Items.Add(listViewItem);
            }
        }
 
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            _formEmployee.Employee = employee;
            if (_formEmployee.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _human.AddEmployee(employee);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = listViewEmployee.SelectedItems[0].Tag as Employee; 
                _formEmployee.Employee = employee;
                if (_formEmployee.ShowDialog() == DialogResult.OK)
                {
                    listViewEmployee.SelectedItems[0].Text = _formEmployee.Employee.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с сотрудником");
            }
        }


        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var typeOfWork = new TypeOfWork();
            _formTypeOfWork.TypeOfWork = typeOfWork;
            if (_formTypeOfWork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _human.AddTypeOfWork(typeOfWork);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var typeOfWork = listViewTypeOfWork.SelectedItems[0].Tag as TypeOfWork;
                _formTypeOfWork.TypeOfWork = typeOfWork;
                if (_formTypeOfWork.ShowDialog() == DialogResult.OK)
                {
                    listViewTypeOfWork.SelectedItems[0].Text = _formTypeOfWork.TypeOfWork.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с видом работы");
            }
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var job = new Job();
            _formJob.Job = job; 
            if (_formJob.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _human.AddJob(job);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var job = listViewJob.SelectedItems[0].Tag as Job;
                _formJob.Job = job; 
                if (_formJob.ShowDialog() == DialogResult.OK)
                {
                    job = _formJob.Job; 
                    var listViewItem = listViewJob.SelectedItems[0];
                    listViewItem.Text = job.Worker.ToString();
                    listViewItem.SubItems[1].Text = job.Position.ToString();
                  
               listViewItem.SubItems[2].Text = job.StartDate.ToShortDateString(); listViewItem.SubItems[3].Text = job.EndDate.ToShortDateString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана строка с работой");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            FormEmployee formClient = new FormEmployee(employee);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                Human.Employees.Add(employee.EmployeeId, formClient.employee);
                UpdateEmployeeList();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = listViewEmployee.SelectedItems[0].Tag as Employee;
            FormEmployee formClient = new FormEmployee(employee);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateEmployeeList();
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var typeOfWork = new TypeOfWork();
            FormTypeOfWork formClient = new FormTypeOfWork(typeOfWork);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                Human.TypeOfWorks.Add(typeOfWork.TypeOfWorkId, formClient.typeOfWork);
                UpdateTypeOfWorkList();
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var typeOfWork = listViewTypeOfWork.SelectedItems[0].Tag as TypeOfWork;
            FormTypeOfWork formClient = new FormTypeOfWork(typeOfWork);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateTypeOfWorkList();
            }
        }


        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var job = new Job();
            FormJob formClient = new FormJob(job);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                Human.Jobs.Add(formClient.job);
                UpdateJobList();
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var job = listViewJob.SelectedItems[0].Tag as Job;
            
            FormJob formClient = new FormJob(job);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateJobList();
            }
        }

        private void UpdateEmployeeList()
        {
            listViewEmployee.Items.Clear();
            foreach (var employee in Human.Employees.Values)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = employee,
                    Text = employee.EmployeeId.ToString()
                };

                listViewItem.SubItems.Add(employee.ToString());
                listViewItem.SubItems.Add(employee.Salary.ToString());
                listViewEmployee.Items.Add(listViewItem);

            }
        }

        private void UpdateTypeOfWorkList()
        {
            listViewTypeOfWork.Items.Clear();
            foreach (var typeOfWork in Human.TypeOfWorks.Values)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = typeOfWork,
                    Text = typeOfWork.TypeOfWorkId.ToString()
                };

                listViewItem.SubItems.Add(typeOfWork.ToString());
                listViewItem.SubItems.Add(typeOfWork.Description.ToString());
                listViewTypeOfWork.Items.Add(listViewItem);

            }
        }

        private void UpdateJobList()
        {
            listViewJob.Items.Clear();
            foreach (var job in Human.Jobs)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = job,
                    Text = job.Worker.ToString()
                };

                listViewItem.SubItems.Add(job.Position.Description.ToString());
                listViewJob.Items.Add(listViewItem);
            }
        }

        */
    }
}
