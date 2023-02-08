using Proiect_DAW___Iftichi_Calin.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Proiect_DAW___Iftichi_Calin.Models.DTOs
{
    public class UserRequestDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public string Prenume { get; set; }
        [Required]
        public Rol Rol { get; set; }

    }
}


