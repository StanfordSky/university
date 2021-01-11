using System;
using System.Collections.Generic;
using System.Text;

/*Прокат автомобилей
3. Выданные автомобили (автомобиль, клиент, дата выдачи, дата возврата).*/
namespace ClassLibraryRentService
{
    /// <summary>
    /// Выданный автомобиль
    /// </summary>
    public class RentedCar
    {
        /// <summary>
        /// Клиент
        /// </summary>
        public Client Client { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public Car Car { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата окончания проживания
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;
        public bool IsValid
        {
            get
            {
                if (Client == null) return false;
                if (Car == null) return false;
                if (EndDate < StartDate) return false;
                return true;
            }

        }
        public RentedCar()
        {

        }
        public RentedCar(Client client, Car car, DateTime startDate, DateTime endDate)
        {
            Client = client;
            Car = car;
            StartDate = startDate;
            EndDate = endDate;

        }
        public override string ToString()
        {
            return $"Клиент:{Client}\r\nАвтомобиль:{Car}\r\nПериод: {StartDate}-{EndDate}\r\n";
        }
    }
        
}
   