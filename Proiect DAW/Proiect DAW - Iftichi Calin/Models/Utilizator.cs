using Microsoft.AspNetCore.Identity;
using Proiect_DAW___Iftichi_Calin.Models.Base;
using Proiect_DAW___Iftichi_Calin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Utilizator : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UtilizatorId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public string Username { get; set; }
        public ICollection<Aplicatie> Aplicatie { get; set; }

        public Rol Rol { get; set; }



    }
}
