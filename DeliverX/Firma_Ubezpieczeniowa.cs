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
    
    public partial class Firma_Ubezpieczeniowa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma_Ubezpieczeniowa()
        {
            this.Ubezpieczenie = new HashSet<Ubezpieczenie>();
        }
    
        public int id_Firma_Ubezpieczeniowa { get; set; }
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public string Państwo { get; set; }
        public string Miasto { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Ulica { get; set; }
        public string Nr_budynku { get; set; }
        public string Nr_telefonu { get; set; }
        public string Adres_e_mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubezpieczenie> Ubezpieczenie { get; set; }
    }
}
