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
    
    public partial class Ubezpieczenie
    {
        public int id_Ubezpieczenie { get; set; }
        public int id_Pojazd { get; set; }
        public int id_Typ_Ubezpieczenia { get; set; }
        public int id_Firma_Ubezpieczeniowa { get; set; }
        public string Nr_polisy { get; set; }
        public System.DateTime Obowiązuje_od { get; set; }
        public System.DateTime Obowiązuje_do { get; set; }
        public decimal Cena { get; set; }
        public string Waluta { get; set; }
    
        public virtual Firma_Ubezpieczeniowa Firma_Ubezpieczeniowa { get; set; }
        public virtual Pojazd Pojazd { get; set; }
        public virtual Typ_Ubezpieczenia Typ_Ubezpieczenia { get; set; }
    }
}