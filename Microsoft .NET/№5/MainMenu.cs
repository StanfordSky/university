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

        public MainMenu()
        {
            InitializeComponent();
        }

        private void UpdateEmployeeList()
        {
            listViewEmployee.Items.Clear();
            foreach (var item in Human.Employees)
            {
                var employee = item.Value;
                var listViewItem = new ListViewItem
                {
                    Text = employee.EmployeeId.ToString()
                };

                listViewEmployee.Items.Add(listViewItem);
                
            }
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
            //FormEmployee dialog_employee = new FormEmployee();
            //dialog_employee.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTypeOfWork dialog_typeofwork = new FormTypeOfWork();
            dialog_typeofwork.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTypeOfWork dialog_typeofwork = new FormTypeOfWork();
            dialog_typeofwork.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormJob dialog_job = new FormJob();
            dialog_job.Show();
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormJob dialog_job = new FormJob();
            dialog_job.Show();
        }
    }
}
