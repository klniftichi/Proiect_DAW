using Proiect_DAW___Iftichi_Calin.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Utilizator : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UtilizatorId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public ICollection<Aplicatie> Aplicatie { get; set; }




    }
}
