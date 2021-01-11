using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryRentService;

namespace WindowsFormsControlLibraryRentService
{
    public partial class UserControlRentedCar : UserControl
    {
        private readonly RentService _rentService = RentService.Instance;
        public RentedCar RentedCar { get; }

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
                            if (!(control is UserControlRentedCar)) continue;
                            var userControlRentedCar = control as UserControlRentedCar;
                            if (userControlRentedCar != this)
                            {
                                userControlRentedCar.Selected = false;
                            }
                        }
                    }
                }
                _selected = value;
                Refresh();
            }
        }

        public UserControlRentedCar(RentedCar rentedCar)
        {
            InitializeComponent();
            RentedCar = rentedCar;
        }

        private void UserControlRentedCar_Paint(object sender, PaintEventArgs e)
        {
            textBoxClient.Text = $@"{RentedCar.Client.Fio.LastName} {RentedCar.Client.Fio.FirstName[0]}.{RentedCar.Client.Fio.MiddleName[0]}.";
            textBoxCar.Text = RentedCar.Car.Number.ToString("0");
            textBoxPeriod.Text = $@"С {RentedCar.StartDate:dd MMMM yyyy} по {RentedCar.EndDate:dd MMMM yyyy}";
            if (RentedCar.EndDate < DateTime.Today)
            {
                textBoxPeriod.BackColor = Color.Green;
            }
            else
            {
                textBoxPeriod.BackColor = RentedCar.StartDate < DateTime.Today ? Color.Yellow : Color.Red;
            }
            BackColor = _selected ? Color.CornflowerBlue : DefaultBackColor;

        }

        private void UserControlRentedCar_Click(object sender, EventArgs e)
        {
            Selected = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _rentService.RemoveRentedCar(RentedCar);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана запись об аренде");
            }
        }
    }
}
