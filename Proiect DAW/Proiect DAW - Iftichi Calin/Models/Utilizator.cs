using Proiect_DAW___Iftichi_Calin.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Utilizator : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UtilizatorId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string ParolaHash { get; set; }
        public ICollection<Aplicatie> Aplicatie { get; set; }




    }
}
