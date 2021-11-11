using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryWork;

namespace WindowsFormsControlLibraryJob
{
    public partial class UserControlJob: UserControl
    {
        private readonly Human _human = Human.Instance;
        public Job Job { get; }
        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if (value)
                {
                    var controls = Parent?.Controls;
                    if (controls != null)
                    {
                        foreach (var control in controls)
                        {
                            if (!(control is UserControlJob)) continue;
                            var userControlJob = control as UserControlJob;
                            if (userControlJob != this)
                            {
                                userControlJob.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }

        public UserControlJob(Job job)
        {
            InitializeComponent();
            Job = job;
        }

        private void UserControlSettlement_Paint(object sender, PaintEventArgs e)
        {
            textBoxEmployee.Text = $@"{Job.Worker.LastName} {Job.Worker.FirstName[0]}.{Job.Worker.Patronymic[0]}.";
            textBoxTypeOfWork.Text = Job.Position.Description.ToString();
            textBoxJob.Text = $@"С {Job.StartDate:dd MMMM yyyy} по {Job.EndDate:dd MMMM yyyy}";
            if (Job.EndDate < DateTime.Today)
            {
                textBoxJob.BackColor = Color.Green;
            }
            else
            {
                textBoxJob.BackColor = Job.StartDate < DateTime.Today ? Color.Yellow : Color.Red;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;
        }

        private void UserControlJob_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 _human.RemoveJob(Job);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о занимаемой должности.");
            }

        }
    }
}
