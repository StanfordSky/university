using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryBjuro.Exception;

namespace ClassLibraryBjuro
{
    public class Dealing : IValidatable
    {
        /// <summary>
        /// Работодатель
        /// </summary>
        public Employer Employer { get; set; }

        /// <summary>
        /// Соискатель
        /// </summary>
        public JobSeeker JobSeeker { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Post { get; set; } = "";

        /// <summary>
        /// Комиссионные
        /// </summary>
        public string Commission { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if (Employer == null) return false;
                if (JobSeeker == null ) return false;
                if (string.IsNullOrWhiteSpace(Post)) return false;
                if (string.IsNullOrWhiteSpace(Commission)) return false;
                return true;
            }
        }

        public Dealing()
        {

        }

        public Dealing(Employer employer, JobSeeker jobSeeker, string post, string comission)
        {
            Employer   = employer;
            JobSeeker  = jobSeeker;
            Post       = post;
            Commission = comission;
        }

        public override string ToString()
        {
            return $"Работодатель: {Employer}\r\nСоискатель: {JobSeeker}\r\nДолжность: {Post}\r\nКомиссионные: {Commission}\r\n";
        }
    }
}
