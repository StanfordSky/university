using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryData
{
    public class MusicaInstrumentInfo
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int TypeOfMusInstFK { get; set; }

        public MusicaInstrumentInfo() { }
    }
    public class TypeOfMusicaInstruentInfo
    {
        public int TypeOfMusInstID { get; set; }
        public string Name { get; set; }
    }
}