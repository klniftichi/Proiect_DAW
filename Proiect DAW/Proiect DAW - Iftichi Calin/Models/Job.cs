namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Job
    {
        public Guid JobId { get; set; }
        public string Nume_Job { get; set; }
        public string Categorie_job { get; set; }
        public string Criterii { get; set; }
        public string Descriere_job { get; set; }
        public Companie Companie { get; set; }
        public ICollection<Aplicatie> Aplicatie { get; set; }


    }
}
