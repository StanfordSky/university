using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

namespace ClassLibraryWork
{

    // ------ Class - Employee ------ //
    [Serializable]
    public class Employee : IValidatable
    {
        // ---- Properties --- //

        /// <summary>
        /// Уникальный идентификатор нового сотрудника
        /// </summary>
        private static int _newEmployeeId = 0;
        public static int NewEmployeeId
        {
            get
            {
                _newEmployeeId++;
                return _newEmployeeId;
            }
            set
            {
                _newEmployeeId = value;
            }
        }

        /// <summary>
        /// Уникальный идентификатор сотрудника
        /// </summary>
        public int EmployeeId { get; set; }
   

        /// <summary>
        ///     Firs tName of worker
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        ///     Last Name of worker
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        ///     Patronymic of worker
        /// </summary>
        public string Patronymic { get; set; } = "";


        /// <summary>
        ///     Salary of worker
        /// </summary>
        public double Salary { get; set; }


        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(Patronymic)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                return true;
            }
        }

        // --- Methods --- //

        /// <summary>
        ///     Default Constructor
        /// </summary>
        public Employee()
        {
            EmployeeId = NewEmployeeId;
        }


        /// <summary>
        ///     The full constructor
        /// </summary>
        public Employee(string firstName, string lastName, string patronymic, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Salary = salary;
        }

        public override string ToString()
        {
            return $" {FirstName} {LastName} {Patronymic} ";                       
        }
    }

}
