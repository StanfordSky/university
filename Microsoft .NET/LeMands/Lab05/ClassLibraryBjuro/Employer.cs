using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBjuro
{
    public class Employer : IValidatable
    {

        /// <summary>
        /// Уникальный идентификатор работодателя (аналог автоинкремента)
        /// </summary>
        private static int _newEmployerId;

        private static int NewEmployerId
        {
            get
            {
                _newEmployerId++;
                return _newEmployerId;
            }
        }

        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int EmployerId { get; }

        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string KindOfActivity { get; set; } = "";

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = "";

        /// <summary>
        /// Телефон
        /// </summary>
        public string PhoneNumber { get; set; } = " ";

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Title)) return false;
                if (string.IsNullOrWhiteSpace(KindOfActivity)) return false;
                if (string.IsNullOrWhiteSpace(Address)) return false;
                if (string.IsNullOrWhiteSpace(PhoneNumber)) return false;
                return true;
            }
        }

        public Employer()
        {
            EmployerId = NewEmployerId;
        }

        public Employer(string title, string kindOfActivity, string address, string phoneNumber)
        {
            Title = title;
            KindOfActivity = kindOfActivity;
            Address = address;
            PhoneNumber = phoneNumber;
            EmployerId = NewEmployerId;
        }

        public override string ToString()
        {
            return $"Название: {Title}\r\nВид деятельности: {KindOfActivity}\r\nАдрес: {Address}\r\nТелефон: {PhoneNumber}\r\n";
        }

    }
}
