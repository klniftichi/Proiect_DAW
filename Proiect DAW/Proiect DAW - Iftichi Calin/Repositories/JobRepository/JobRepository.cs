using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models;

namespace Proiect_DAW___Iftichi_Calin.Repositories.SediuRepository
{
    public class JobRepository : GenericRepository.GenericRepository<Job>, IJobRepository
    {
        public JobRepository(ProiectContext context) : base(context)
        {

        }

        public List<Job> GetAllWithInclude()
        {
            return _table.Include(x=>x.Companie).Include(x=>x.Aplicatie).ToList();
        }
        /*public List<Job> GetAllWithJoin()
        {
            
        }*/

        public Job GetByCategory(string category) 
        {
            return _table.FirstOrDefault(x => x.Categorie_job.ToLower().Equals(category.ToLower()));
        }
    }
}
