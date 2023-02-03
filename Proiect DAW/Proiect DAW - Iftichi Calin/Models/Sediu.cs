using Proiect_DAW___Iftichi_Calin.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Sediu : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SediuId { get; set; }
        public string Oras { get; set; }
        public string Adresa { get; set; }
        public Companie Companie { get; set; }

    }
}
