using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBjuro 
{
    /// <summary>
    /// Соискатель
    /// </summary>
    [Serializable]
    public class JobSeeker : IValidatable
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Number { get; set; } = 1;

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

        /// <summary>
        /// Квалификация
        /// </summary>
        public string Qualification { get; set; } = " ";

        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string KindOfActivity { get; set; } = " ";

        /// <summary>
        /// Паспортные данные
        /// </summary>
        public PassportInfo Passport { get; set; } = new PassportInfo();

        /// <summary>
        /// Предполагаемый размер заработной платы
        /// </summary>
        public string Salary { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (string.IsNullOrWhiteSpace(Qualification)) return false;
                if (string.IsNullOrWhiteSpace(KindOfActivity)) return false;
                if (Passport == null) return false;
                if (string.IsNullOrWhiteSpace(Salary)) return false;
                return true;
            }
        }

        public JobSeeker()
        {

        }

        public JobSeeker(string firstName, string lastName, string middleName, string qualification, string kindOfActivity, string salary)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Qualification = qualification;
            KindOfActivity = kindOfActivity;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя: {FirstName}\r\nОтчество: {MiddleName}\r\nКвалификация: {Qualification}\r\nВид деятельности: {KindOfActivity}\r\nПаспортные данные: {Passport}\r\nПредполагаемый размер заработной платы: {Salary}\r\n";
        }
    }
}
