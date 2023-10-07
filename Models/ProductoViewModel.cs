using System.ComponentModel.DataAnnotations;

namespace Foro2.Models
{
    public class ProductoViewModel
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}