using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryData
{
    public partial class FilmDTO
    {
        public int id { get; set; }
        public Nullable<int> producer { get; set; }
        public byte[] cover { get; set; }
        public Nullable<int> year { get; set; }
        public string Title { get; set; }


    }
    public partial class ProducerDTO
    {



        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }


    }
}
