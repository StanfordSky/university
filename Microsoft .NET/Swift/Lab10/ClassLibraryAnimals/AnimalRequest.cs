using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryAnimals
{
    public class AnimalRequest
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public AnimalRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о городе
        /// </summary>
        public Animal Animal{ get; set; }
    }
}
