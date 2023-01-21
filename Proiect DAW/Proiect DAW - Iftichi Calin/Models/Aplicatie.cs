namespace Proiect_DAW___Iftichi_Calin.Models
{
    public class Aplicatie //pentru many2many intre utilizator si job
    {

        public Guid UtilizatorId { get; set; }

        public Utilizator Utilizator { get; set; }
        public Guid JobId { get; set; }

        public Job Job { get; set; }
        

    }
}
