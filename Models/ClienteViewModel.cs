using System.ComponentModel.DataAnnotations;

namespace Foro2.Models
{
    public class ClienteViewModel
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }
    }
}
