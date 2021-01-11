using System;
using System.Windows.Forms;
using ClassLibraryRentService;

namespace Lab4_2
{
    public partial class FormRentedCar : Form
    {
        private RentedCar _rentedCar;
        public RentedCar RentedCar { get {return _rentedCar; }
        set {
                _rentedCar = value;
                comboBoxClient.SelectedItem = _rentedCar.Client;
                comboBoxCar.SelectedItem = _rentedCar.Car;
                dateTimePickerStartDate.Value = _rentedCar.StartDate;
                dateTimePickerEndDate.Value = _rentedCar.EndDate;
            }
        }
        private readonly RentService _rentService = RentService.Instance;
        public FormRentedCar()
        {
            InitializeComponent();
            _rentService.ClientAdded += _rentSerivce_ClientAdded;
            _rentService.ClientRemoved += _rentSerivce_ClientRemoved;
            _rentService.CarAdded += _rentSerivce_CarAdded;
            _rentService.CarRemoved += _rentSerivce_CarRemoved;
            foreach (var client  in _rentService.Clients)
            {
               
                comboBoxClient.Items.Add(client);
            }
            foreach (var car in _rentService.Cars)
            {
              
                comboBoxCar.Items.Add(car);
            } 
        }
        private void _rentSerivce_CarRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxCar.Items.Count; i++)
            {
                var Car = comboBoxCar.Items[i] as Car;
                if (Car?.Number == key)
                {
                    comboBoxCar.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _rentSerivce_CarAdded(object sender, EventArgs e)
        {
            comboBoxCar.Items.Add(sender);
        }

        private void _rentSerivce_ClientRemoved(object sender, EventArgs e)
        {
            int key = (int)sender;
            for (int i = 0; i < comboBoxClient.Items.Count; i++)
            {
                var client = comboBoxClient.Items[i] as Client;
                if (client?.ClientId == key)
                {
                    comboBoxClient.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void _rentSerivce_ClientAdded(object sender, EventArgs e)
        {
            comboBoxClient.Items.Add(sender);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            RentedCar.Client = comboBoxClient.SelectedItem as Client;
            RentedCar.Car = comboBoxCar.SelectedItem as Car;
            RentedCar.StartDate = dateTimePickerStartDate.Value;
            RentedCar.EndDate = dateTimePickerEndDate.Value;
        }
    }
}
