//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeliverX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uprawnienie
    {
        public int id_Uprawnienia { get; set; }
        public int id_Pracownik { get; set; }
        public int id_Typ_Pojazdu { get; set; }
        public string Nr_dokumentu { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Typ_Pojazdu Typ_Pojazdu { get; set; }
    }
}
