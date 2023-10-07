using System.ComponentModel.DataAnnotations;

namespace Foro2.Models
{
    public class UsuarioViewModel
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string CorreoElectronico { get; set; }
    }
}