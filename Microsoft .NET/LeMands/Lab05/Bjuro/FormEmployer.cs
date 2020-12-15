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
    public partial class FormEmployer : Form
    {
        public Employer Employer { get; }
        public FormEmployer(Employer employer)
        {
            InitializeComponent();
            Employer = employer;
            textBoxTitle.Text = Employer.Title;
            textBoxKindOfActivity.Text = Employer.KindOfActivity;
            textBoxAddress.Text = Employer.Address;
            maskedTextBoxPhoneNumber.Text = Employer.PhoneNumber;

        }

        private void FormEmployer_Load(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Employer.Title = textBoxTitle.Text;
            Employer.KindOfActivity = textBoxKindOfActivity.Text;
            Employer.Address = textBoxAddress.Text;
            Employer.PhoneNumber = maskedTextBoxPhoneNumber.Text;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
