using System;
using System.Windows.Forms;
using ClassLibraryRentService;
namespace Lab4_2
{
    public partial class FormClient : Form
    {
        private Client _client;
        public Client Client
        {
            get { return _client; }
            set
            {
                _client = value;
                FirstNameTextBox.Text = Client.Fio.FirstName;
                MiddleNameTextBox.Text = Client.Fio.MiddleName;
                LastNameTextBox.Text = Client.Fio.LastName;
                AdressTextBox.Text = Client.Adress;
                maskedTextBoxPhone.Text = Client.PhoneNumber;
            }
        }
        public FormClient()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            _client.Fio.FirstName = FirstNameTextBox.Text;
            _client.Fio.MiddleName = MiddleNameTextBox.Text;
            _client.Fio.LastName = LastNameTextBox.Text;
            _client.Adress = AdressTextBox.Text;
            _client.PhoneNumber = maskedTextBoxPhone.Text;
        }
    }
}
