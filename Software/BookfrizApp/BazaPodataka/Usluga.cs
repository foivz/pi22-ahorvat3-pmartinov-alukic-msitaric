//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BazaPodataka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usluga()
        {
            this.Cjeniks = new HashSet<Cjenik>();
        }
    
        public int idUsluga { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public double Cijena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cjenik> Cjeniks { get; set; }
    }
}
