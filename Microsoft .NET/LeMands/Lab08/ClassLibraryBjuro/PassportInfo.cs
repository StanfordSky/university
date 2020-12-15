using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBjuro
{
    [Serializable]
    public class PassportInfo
    {
        /// <summary>
        /// Номер паспорта
        /// </summary>
        public string Number { get; set; } = "000000";

        /// <summary>
        /// Серия паспорта
        /// </summary>
        public string Seria { get; set; } = "0000";

        /// <summary>
        /// Дата выдачи паспорта
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Today;

        /// <summary>
        /// Кем выдан паспорт
        /// </summary>
        public string Issuer { get; set; } = "";

        public override string ToString()
        {
            return $"{Seria} {Number}";
        }

    }
}
