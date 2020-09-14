using System;

namespace _4_1
{
    internal interface IValidatable
    {
        bool IsValid { get; }
    }

    // ------ Class - Employee ------ //
    public class Employee : IValidatable
    {
        // ---- Properties --- //

        /// <summary>
        ///     Firs tName of worker
        /// </summary
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
            return "First Name - " + FirstName + ", Last Name - " + LastName + ", Patronymic - " + Patronymic +
                   ".\r\nSalary = " + Salary + ".\r\n\n";
        }
    }


    // ------ Class - Type of Work ------ //
    public class TypeOfWork : IValidatable
    {
        // ---- Properties --- ///

        /// <summary>
        ///     Payment per Day of worker
        /// </summary>
        public int PaymentPerDay { get; set; } = -1;

        /// <summary>
        ///     Description position of worker
        /// </summary>
        public string Description { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if (PaymentPerDay == -1) return false;
                if (string.IsNullOrWhiteSpace(Description)) return false;
                return true;
            }
        }


        // --- Methods --- //

        /// <summary>
        ///     Default Constructor
        /// </summary>
        public TypeOfWork()
        {
        }

        /// <summary>
        ///     The full constructor
        /// </summary>
        public TypeOfWork(string description, int paymentPerDay)
        {
            Description = description;
            PaymentPerDay = paymentPerDay;
        }

        public override string ToString()
        {
            return "Payment per Day = " + PaymentPerDay + ".\r\n Description: " + Description + ".\r\n";
        }
    }


    // ------ Class - Job ------ //
    public class Job : IValidatable
    {
        // ---- Properties --- ///

        /// <summary>
        ///     information about worker
        /// </summary>
        public Employee Worker;

        /// <summary>
        ///     information about position of worker
        /// </summary>
        public TypeOfWork Position;

        /// <summary>
        ///     Start date work
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.MinValue;

        /// <summary>
        ///     End Date work
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.MinValue;

        public bool IsValid
        {
            get
            {
                if (StartDate == DateTime.MinValue) return false;
                if (EndDate == DateTime.MinValue) return false;
                return true;
            }
        }


        // --- Methods --- //

        /// <summary>
        ///     Default Constructor
        /// </summary>
        public Job()
        {
        }

        /// <summary>
        ///     The full constructor
        /// </summary>
        public Job(Employee worker, TypeOfWork position, DateTime startDate, DateTime endDate)
        {
            Worker = worker;
            Position = position;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return "Worker: " + Worker.FirstName + " " + Worker.LastName + " " + Worker.Patronymic + ".\r\n" +
                   "Position - " + Position.Description + ".\r\n" +
                   "Date: " + StartDate + " - " + EndDate + ".\r\n";
        }
    }
}