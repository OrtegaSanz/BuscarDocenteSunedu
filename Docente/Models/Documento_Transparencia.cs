//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Docente.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documento_Transparencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documento_Transparencia()
        {
            this.TRANSPARENCIA = new HashSet<TRANSPARENCIA>();
        }
    
        public int id_Documento { get; set; }
        public string DescripcionDocTransp { get; set; }
        public byte[] ArchivoTransp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSPARENCIA> TRANSPARENCIA { get; set; }
    }
}
