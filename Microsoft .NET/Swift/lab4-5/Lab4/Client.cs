using ClassLibraryRentService;
using System;

/*Прокат автомобилей
2. Клиенты (фамилия, имя, отчество, адрес, телефон).*/
namespace ClassLibraryRentService
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client : IValidatable
    {
        /// <summary>
        /// Уникальный идентификатор нового клиента (аналог автоинкремента)
        /// </summary>
  
        private static int _newClientId;
        public static int NewClientId
        {
            get
            {
                _newClientId++;
                return _newClientId;
            }
            set
            {
                _newClientId = value;
            }
        }
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int ClientId { get; set; }

        public FIO Fio { get; set; } = new FIO();
        /// <summary>
        /// Адрес
        /// </summary>
        public string Adress { get; set; } = "";
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; } = "";
       

        public bool IsValid
        {
            get
            {
                if
                (!Fio.IsValid)return false;
                if
                (string.IsNullOrWhiteSpace(Adress)) return false;
                if
                (string.IsNullOrWhiteSpace(PhoneNumber)) return false;
                return true;
            }
        }


        public Client()
        {
            ClientId = NewClientId;
        }
        public Client(string firstName, string
        lastName, string middleName,string adress,string phoneNumber)
        {
            Fio = new FIO(firstName, lastName, middleName);
            Adress = adress;
            PhoneNumber = phoneNumber;
            ClientId = NewClientId;

        }
        public override string ToString()
        {
            return $" {Fio}Адресс: { Adress}\r\nНомер телефона: { PhoneNumber}\r\n";
        }
    }

}
