using ClassLibraryRentService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class FormCar : Form
    {
        private Car _car;
        public Car Car
        { get 
            {
                return _car;
            }
            set
            {
                _car = value;
                numericUpDownNumber.Value = _car.Number;
                TypeComboBox.SelectedItem = _car.Type;
                MarkTextBox.Text = _car.Mark;
                PriceNumericUpDown.Value = _car.Price;
                PriceRentNumericUpDown.Value = _car.PriceRent;
            }
        }
        public FormCar()
        {
            InitializeComponent();
            TypeComboBox.Items.Add(CarType.Motorcycle);
            TypeComboBox.Items.Add(CarType.PassengerСar);
            TypeComboBox.Items.Add(CarType.Truck);
          
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _car.Number = (int)numericUpDownNumber.Value;
            _car.Mark = MarkTextBox.Text;
            _car.Price = PriceNumericUpDown.Value;
            _car.PriceRent = PriceRentNumericUpDown.Value;
            _car.Type = (CarType)TypeComboBox.SelectedItem;
        }

        private void FormCar_Load(object sender, EventArgs e)
        {

        }
    }
}
