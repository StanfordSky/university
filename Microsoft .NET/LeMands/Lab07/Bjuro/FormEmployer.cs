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
        private Employer _employer;
        public Employer Employer 
        {
            get { return _employer; }
            set 
            {
                _employer = value;
                textBoxTitle.Text = Employer.Title;
                textBoxKindOfActivity.Text = Employer.KindOfActivity;
                textBoxAddress.Text = Employer.Address;
                maskedTextBoxPhoneNumber.Text = Employer.PhoneNumber;
            }
        }
        public FormEmployer()
        {
            InitializeComponent();
        }

        private void FormEmployer_Load(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _employer.Title = textBoxTitle.Text;
            _employer.KindOfActivity = textBoxKindOfActivity.Text;
            _employer.Address = textBoxAddress.Text;
            _employer.PhoneNumber = maskedTextBoxPhoneNumber.Text;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
