namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class AplicatieJob
    {
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public Guid UtilizatorId { get; set; }
        public Utilizator Utilizator { get; set; }
    }
}
