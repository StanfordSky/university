using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBjuro.Serialization
{
    [Serializable]
    public class DealingSerializable
    {
        public int JobSeekerId { get; set; }
        public int EmployerId { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string Post { get; set; } = "";
        /// <summary>
        /// Комиссионные
        /// </summary>
        public string Commission { get; set; } = "";
    }
}
