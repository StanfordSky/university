namespace ClassLibraryWork
{

    // ------ Class - Type of Work ------ //
    public class TypeOfWork : IValidatable
    {
        // ---- Properties --- ///

        /// <summary>
        /// Уникальный идентификатор нового типа работы
        /// </summary>
        private static int _newTypeOfWorkId = 0;
        private static int NewTypeOfWorkId
        {
            get
            {
                _newTypeOfWorkId++;
                return _newTypeOfWorkId;
            }
        }

        /// <summary>
        /// Уникальный идентификатор сотрудника
        /// </summary>
        public int TypeOfWorkId { get; set; }

        /// <summary>
        ///     Payment per Day of worker
        /// </summary>
        public int PaymentPerDay { get; set; } = 1;

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
            TypeOfWorkId = NewTypeOfWorkId;
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
            return $"{PaymentPerDay}";
        }
    }

}
