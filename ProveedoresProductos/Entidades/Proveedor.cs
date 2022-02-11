//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(ProveedorDataAnotations))]
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            this.Productos = new HashSet<Productos>();
        }
    
        public long IdProveedor { get; set; }
        public string codigo { get; set; }
        public string razon_social { get; set; }
        public string rfc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
    public class ProveedorDataAnotations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        [Display(Name = "Id del proveedor")]
        public long IdProveedor { get; set; }
        [Required(ErrorMessage = "El código es obligatorio")]
        [Display(Name = "Código")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "La razón social es obligatoria")]
        [Display(Name = "Razón social")]
        public string razon_social { get; set; }
        [RegularExpression("[A-Z]{4}[0-9]{6}[A-Z]{1}[0-9]{2}", ErrorMessage = "El rfc no tiene el formato correcto")]
        [Required(ErrorMessage = "El rfc es obligatorio")]
        [Display(Name = "RFC")]
        public string rfc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
