using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee dialog_employee = new Employee();
            dialog_employee.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee dialog_employee = new Employee();
            dialog_employee.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TypeOfWork dialog_typeofwork = new TypeOfWork();
            dialog_typeofwork.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TypeOfWork dialog_typeofwork = new TypeOfWork();
            dialog_typeofwork.Show();
        }
    }
}
