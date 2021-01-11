using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryAnimals
{ /// <summary>
  /// Ответ от справочника животных
  /// </summary>
    public class AnimalResponse
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Признак успешного выполнения запроса
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Информация о городе
        /// </summary>
        public Animal Animal { get; set; }
    }
}
       

