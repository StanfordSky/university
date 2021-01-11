using Lab11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class FormProducer : Form
    {
        private Producer _producer;
        public Producer Producer
        {
            get { return _producer; }
            set
            {
                _producer = value;
                textBoxFirstName.Text = _producer.FirstName;
                textBoxLastName.Text = _producer.LastName;
            }
        }
        public FormProducer()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Producer.FirstName = textBoxFirstName.Text;         
            Producer.LastName = textBoxLastName.Text;
   
        }

        private void FormProducer_Load(object sender, EventArgs e)
        {

        }
    }
}
