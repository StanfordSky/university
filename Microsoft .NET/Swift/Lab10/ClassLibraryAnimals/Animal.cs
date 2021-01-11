using System;

namespace ClassLibraryAnimals
{
    [Serializable]
    /// <summary>
    /// Животное
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Латинское название
        /// </summary>
        public string Latin_Title { get; set; }
        /// <summary>
        /// Ареал обитания
        /// </summary>
        public string  Habitat { get; set; }
        /// <summary>
        /// Охранный статус
        /// </summary>
        public string Protection_Status { get; set; }
        
    }
}
