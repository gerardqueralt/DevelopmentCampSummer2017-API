//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevelopmentCamp.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artista()
        {
            this.ProductoArtistas = new HashSet<ProductoArtista>();
        }
    
        public int IdArtista { get; set; }
        public string Nombre { get; set; }
        public string Apellido_1 { get; set; }
        public Nullable<int> Edad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoArtista> ProductoArtistas { get; set; }
    }
}
