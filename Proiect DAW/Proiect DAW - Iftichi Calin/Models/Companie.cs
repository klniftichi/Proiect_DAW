namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Companie
    {
        public Guid CompanieId { get; set; }
        public string Nume_companie { get; set; }
        public string Descriere_companie { get; set; }
        public Guid SediuId { get; set; }
        public string Email { get; set; }
        public string ParolaHash { get; set; }
        public ICollection<Job> Joburi { get; set; }
        public Sediu Sediu { get; set; }

    }
}
