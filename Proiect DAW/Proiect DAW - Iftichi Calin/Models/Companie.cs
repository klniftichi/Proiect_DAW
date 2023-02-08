using Proiect_DAW___Iftichi_Calin.Models.Base;
using Proiect_DAW___Iftichi_Calin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Companie : BaseEntity
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CompanieId { get; set; }
        public string? Nume_companie { get; set; }
        public string? Descriere_companie { get; set; }
        public Guid SediuId { get; set; }
        public string? Email { get; set; }
        public string? ParolaHash { get; set; }
        public ICollection<Job> Joburi { get; set; }
        public Sediu Sediu { get; set; }
        public Rol Roluri { get; set; }
    }
}
