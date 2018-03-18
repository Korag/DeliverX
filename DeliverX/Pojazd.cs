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
    
    public partial class Pojazd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pojazd()
        {
            this.Kurs = new HashSet<Kurs>();
            this.Ubezpieczenie = new HashSet<Ubezpieczenie>();
        }
    
        public int id_Pojazd { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nr_rejestracyjny { get; set; }
        public int id_Typ_Pojazdu { get; set; }
        public double Max_ładowność { get; set; }
        public string Jednostka_ładowności { get; set; }
        public System.DateTime Rocznik { get; set; }
        public double Stan_licznika { get; set; }
        public string Jednostka_licznika { get; set; }
        public System.DateTime Stan_licznika_na_dzień { get; set; }
        public string Rodzaj_paliwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kurs> Kurs { get; set; }
        public virtual Typ_Pojazdu Typ_Pojazdu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubezpieczenie> Ubezpieczenie { get; set; }
    }
}