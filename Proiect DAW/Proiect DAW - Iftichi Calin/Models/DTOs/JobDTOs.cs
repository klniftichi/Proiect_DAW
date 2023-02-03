namespace Proiect_DAW___Iftichi_Calin.Models.DTOs
{
    public class JobDTO
    { 
        public string Nume_Job { get; set; }
        public string Categorie_job { get; set; }
        public string Criterii { get; set; }
        public string Descriere_job { get; set; }
        public Guid CompanieId { get; set; }
    }
}
