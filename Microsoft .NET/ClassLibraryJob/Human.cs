using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWork
{
    /// <summary>
    /// Человек
    /// </summary>
    public class Human
    {
        /// <summary>
        /// Словарь сотрудников
        /// </summary>
        public static Dictionary<int, Employee> Employees { get; } = new Dictionary<int, Employee>();
        /// <summary>
        /// Словарь работ
        /// </summary>
        public static Dictionary<int, Job> Jobs{ get; } = new Dictionary<int, Job>();
        /// <summary>
        /// Спосок видов работ
        /// </summary>
        public static List<TypeOfWork> TypeOfWorks { get; } = new List<TypeOfWork>();
    }
}
