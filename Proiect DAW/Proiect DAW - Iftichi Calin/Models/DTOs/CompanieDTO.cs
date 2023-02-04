namespace Proiect_DAW___Iftichi_Calin.Models.DTOs
{
    public class CompanieDTO
    {
        public Guid CompanieId { get; set; }
        public string? Nume_companie { get; set; }
        public string? Descriere_companie { get; set; }
        public Guid SediuId { get; set; }
        public string Oras { get; set; }
        public string Adresa { get; set; }


    }
}
