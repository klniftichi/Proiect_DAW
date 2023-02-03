using Proiect_DAW___Iftichi_Calin.Models.DTOs;

namespace Proiect_DAW___Iftichi_Calin.Services.DemoService
{
    public interface IJobService
    { 
        JobDTO GetDataMappedByCategory(string categorie);   
    }
}
