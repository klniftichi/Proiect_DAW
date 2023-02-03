using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Repositories.GenericRepository;

namespace Proiect_DAW___Iftichi_Calin.Repositories.SediuRepository
{
    public interface IJobRepository : IGenericRepository<Job>
    {
        public List<Job> GetAllWithInclude();

       // public List<Job> GetAllWithJoin();
        Job GetByCategory(string category); 
    }
}
