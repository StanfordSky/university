using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBjuro;

namespace WindowsFormsControlLibraryBjuro
{
    public partial class UserControlDealing: UserControl
    {
        private readonly EmploymentAgency _employmentAgency = EmploymentAgency.Instance;
        public Dealing Dealing { get; }

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
                            if (!(control is UserControlDealing)) continue;
                            var userControlDealing = control as UserControlDealing;
                            if (userControlDealing != this)
                            {
                                userControlDealing.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }
        public UserControlDealing(Dealing dealing)
        {
            InitializeComponent();
            Dealing = dealing;
        }

        private void UserControlDealing_Paint(object sender, PaintEventArgs e)
        {
            textBoxEmployer.Text = $@"{Dealing.Employer.Title} {Dealing.Employer.KindOfActivity}.{Dealing.Employer.Address}.{Dealing.Employer.PhoneNumber}.";
            textBoxJobSeeker.Text = $@"{Dealing.JobSeeker.FirstName} {Dealing.JobSeeker.MiddleName}.{Dealing.JobSeeker.LastName}.{Dealing.JobSeeker.Qualification}.{Dealing.JobSeeker.KindOfActivity}.";
            textBoxPost.Text = Dealing.Post;
            textBoxCommission.Text = Dealing.Commission;
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;

        }

        private void UserControlDealing_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            try
            {
                _employmentAgency.RemoveDealing(Dealing);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись о сделке");
            }
        }
    }
}
