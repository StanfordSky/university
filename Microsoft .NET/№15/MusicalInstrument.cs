//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOTNET_15_new
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusicalInstrument
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TypeOfMusInstFK { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
    
        public virtual TypeOfMusicalInstrument TypeOfMusicalInstrument { get; set; }
    }
}
