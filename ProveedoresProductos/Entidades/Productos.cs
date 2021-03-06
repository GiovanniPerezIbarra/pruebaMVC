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

    [MetadataType(typeof(ProductosrDataAnotations))]
    public partial class Productos
    {
        public long IdProducto { get; set; }
        public long IdProveedor { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string unidad { get; set; }
        public decimal costo { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
    }
    public  class ProductosrDataAnotations
    {
        [Display(Name = "Id del producto")]
        public long IdProducto { get; set; }
        [Required(ErrorMessage = "El id del proveedor es obligatorio")]
        [Display(Name = "Id del proveedor")]
        public long IdProveedor { get; set; }
        [Required(ErrorMessage = "El código es obligatorio")]
        [Display(Name = "Código")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        [Required(ErrorMessage = "La unidad es obligatoria")]
        [Display(Name = "Unidad")]
        public string unidad { get; set; }
        [Required(ErrorMessage = "El costo es obligatorio")]
        [Display(Name = "Costo")]
        public decimal costo { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
