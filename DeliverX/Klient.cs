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
    
    public partial class Klient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klient()
        {
            this.Przesyłka = new HashSet<Przesyłka>();
            this.Przesyłka1 = new HashSet<Przesyłka>();
            this.Przesyłka2 = new HashSet<Przesyłka>();
        }
    
        public int id_Klient { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Państwo { get; set; }
        public string Miasto { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Ulica { get; set; }
        public string Nr_domu_mieszkania { get; set; }
        public string Nr_telefonu { get; set; }
        public string Adres_e_mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przesyłka> Przesyłka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przesyłka> Przesyłka1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przesyłka> Przesyłka2 { get; set; }
    }
}
