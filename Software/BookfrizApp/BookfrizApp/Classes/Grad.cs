﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookfrizApp.Classes
{
    using BazaPodataka;
    using System;
    using System.Collections.Generic;

    public partial class Gradd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gradd()
        {
            this.Salon = new HashSet<Salon>();
        }

        public int idGrad { get; set; }
        public byte[] Naziv { get; set; }
        public Nullable<int> PosBroj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salon> Salon { get; set; }
    }
}
