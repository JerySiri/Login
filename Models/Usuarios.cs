using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginBlazorAplicada2.Models
{
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe escribir una clave.")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "Debe escribir un alias.")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "Debe escribir un nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe escribir un email.")]
        [EmailAddress(ErrorMessage = "El texto escrito debe ser un email.")]
        public string Email { get; set; }
    }
}
