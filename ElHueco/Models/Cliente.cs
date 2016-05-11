using System.ComponentModel.DataAnnotations;

namespace ElHueco.Models
{
    public class Cliente
    {
        [Required]
        public int id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="Nombre")]
        public string nombreCliente { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="Documento de Identidad")]
        public string documentoId { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="Direccion")]
        public string direccion { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Telefono")]
        public string telefono { get; set; }

        public Cliente() { }

        public Cliente(string nombreCliente, string documentoId, string telefono, string direccion)
        {
            this.nombreCliente = nombreCliente;
            this.documentoId = documentoId;
            this.telefono = telefono;
            this.direccion = direccion;
        }

    }
}