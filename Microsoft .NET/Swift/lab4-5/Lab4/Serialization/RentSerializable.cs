using System;


namespace ClassLibraryRentService.Serialization
{
    [Serializable]
    public class RentSerializable
    {
        public int CarId { get; set; }
        public int ClientId { get; set; }
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
