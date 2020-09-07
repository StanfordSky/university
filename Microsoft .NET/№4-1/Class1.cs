using System;
using System.Collections.Generic;


namespace _4_1
{
    interface IValidatable
    {
        bool IsValid { get; }
    }

    // ------ Class - Employee ------ //
    public class Employee  : IValidatable
    {
        // ---- Properties --- //

        /// <summary>
        /// Firs tName of worker
        /// </summary>
        
        public string FirstName    { get; set; } = "";
        /// <summary>
        /// Last Name of worker
        /// </summary>

        public string LastName     { get; set; } = "";
        /// <summary>
        /// Patronymic of worker
        /// </summary>
        public string Patronymic   { get; set; } = "";


        /// <summary>
        /// Salary of worker
        /// </summary>
        public double Salary       { get; set; }


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
        /// Default Constructor
        /// </summary>
        public Employee()
        {
            
        }


        /// <summary>
        /// The full constructor
        /// </summary>
        public Employee(string FirstName, string LastName, string Patronymic, double Salary)
        {
            this.FirstName      = FirstName;
            this.LastName       = LastName;
            this.Patronymic     = Patronymic;
            this.Salary         = Salary;
        }

        public override string ToString()
        {
            return "First Name - " + FirstName + ", Last Name - " + LastName + ", Patronymic - " + Patronymic + ".\r\nSalary = " + Salary + ".\r\n\n";
        }

    }







    // ------ Class - Type of Work ------ //
    public class TypeOfWork : IValidatable
    {
        // ---- Properties --- ///

        /// <summary>
        /// Payment per Day of worker
        /// </summary>
        public double PaymentPerDay { get; set; } = -1;
        /// <summary>
        /// Description position of worker
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
        /// Default Constructor
        /// </summary>
        public TypeOfWork()
        {

        }

        /// <summary>
        /// The full constructor
        /// </summary>
        public TypeOfWork(string Description, double PaymentPerDay)
        {
            this.Description = Description;
            this.PaymentPerDay = PaymentPerDay;
        }

        public override string ToString()
        {
            return "Payment per Day = " + PaymentPerDay + ".\r\nDescrption: " + Description + ".\r\n";
        }
    }









    // ------ Class - Job ------ //
    public class Job : IValidatable
    {
        // ---- Properties --- ///

        /// <summary>
        /// information about worker
        /// </summary>
        public Employee Worker;

        /// <summary>
        /// information about position of worker
        /// </summary>
        public TypeOfWork Position;

        /// <summary>
        /// Start date work
        /// </summary>
        public DateTime StartDate    { get; set; } = DateTime.MinValue;

        /// <summary>
        /// End Date work
        /// </summary>
        public DateTime EndDate      { get; set; } = DateTime.MinValue;

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
        /// Default Constructor
        /// </summary>
        public Job()
        {

        }

        /// <summary>
        /// The full constructor
        /// </summary>
        public Job(Employee Worker, TypeOfWork Position, DateTime StartDate, DateTime EndDate)
        {
            this.Worker = Worker;
            this.Position = Position;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        public override string ToString()
        {
            return "Worker: " + Worker.FirstName + " " + Worker.LastName + " " + Worker.Patronymic + ".\r\n" +
                "Position - " + Position.Description + ".\r\n" +
                "Date: " + StartDate + " - " + EndDate + ".\r\n";
        }
    }
}
