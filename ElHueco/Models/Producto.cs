using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElHueco.Models
{
    public class Producto
    {
        [Required]
        [Display(Name ="Codigo Producto")]
        public int id { get; set; }

        [MaxLength(100)]
        [Display(Name ="Nombre Producto")]
        [DataType(DataType.Text)]
        public string nombreProducto {get; set;}

        [Required]
        [Display(Name ="Precio Venta")]
        [DataType(DataType.Currency)]
        public int precioVenta { get; set; }

        [Required]
        [Display(Name = "Costo")]
        [DataType(DataType.Currency)]
        public int costoProducto { get; set; }
        
        [Display(Name = "Existencias")]
        public int existencias { get; set; }

        public Producto() { }

        public Producto(string nombreProducto, int precioVenta, int costo)
        {
            this.nombreProducto = nombreProducto;
            this.precioVenta = precioVenta;
            this.costoProducto = costo;
        }

    } 

    
}