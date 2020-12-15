using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBjuro
{

    /// <summary>
    /// Бюро по трудоустройству
    /// </summary>

    public class EmploymentAgency
    {
        /// <summary>
        /// Словарь работодателей
        /// </summary>
        public static Dictionary<int, Employer> Employers { get; } = new Dictionary<int, Employer>();
        /// <summary>
        /// Словарь соискателей
        /// </summary>
        public static Dictionary<int, JobSeeker> JobSeekers { get; } = new Dictionary<int, JobSeeker>();
        /// <summary>
        /// Список сделок
        /// </summary>
        public static List<Dealing> Dealings { get; } = new List<Dealing>();

    }
}
