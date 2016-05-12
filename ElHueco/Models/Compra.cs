using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElHueco.Models
{
    public class Compra
    {
        public int id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="Proveedor")]
        public string proveedor { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Ruta soporte")]
        public string pathSoporte { get; set; }

        //public HttpPostedFileBase soporteCompra { get; set; }

        public Compra() { }
    }
}