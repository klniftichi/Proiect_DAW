using Proiect_DAW___Iftichi_Calin.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Job : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid JobId { get; set; }
        public string Nume_Job { get; set; }
        public string Categorie_job { get; set; }
        public string Criterii { get; set; }
        public string Descriere_job { get; set; }
        public Companie Companie { get; set; }
        public ICollection<Aplicatie> Aplicatie { get; set; }


    }
}
