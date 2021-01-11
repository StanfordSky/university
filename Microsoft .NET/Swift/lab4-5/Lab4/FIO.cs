using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryRentService
{
    /// <summary>
    /// ФИО
    /// </summary>
    public class FIO: IValidatable
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = "";
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = "";
        public bool IsValid
        {
            get
            {
                if
                (string.IsNullOrWhiteSpace(FirstName)) return false;
                if
                (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if
                (string.IsNullOrWhiteSpace(LastName)) return false;
                return true;
            }
        }
       
        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя:{ FirstName}\r\nОтчество: { MiddleName}\r\n";
        }
   
        public FIO()
        {
        }
        public FIO(string firstName, string
        lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;

        }
    }
}
