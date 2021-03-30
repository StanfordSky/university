using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibraryWork;

namespace _4_2
{
    public partial class FormEmployee : Form
    {

        public Employee employee { get; set; }

        public FormEmployee(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
            this.employee.FirstName = textBoxFirstName.Text;
            this.employee.LastName = textBoxLastName.Text;
            this.employee.Patronymic = textBoxPatronymic.Text;
            this.employee.Salary = Convert.ToDouble(numericUpDownSalary.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
