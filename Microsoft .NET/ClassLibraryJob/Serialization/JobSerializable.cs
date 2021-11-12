using System;


namespace ClassLibraryWork.Serialization
{
    [Serializable]
    public class JobSerializable
    {
        public int Employee { get; set; }
        public int TypeOfWork { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата окончания проживания
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
