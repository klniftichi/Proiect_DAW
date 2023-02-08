using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Repositories.GenericRepository;

namespace Proiect_DAW___Iftichi_Calin.Repositories.UtilizatorRepository
{
    public class UtilizatorRepository : GenericRepository<Utilizator>, IUtilizatorRepository
    {
        public UtilizatorRepository(ProiectContext context) : base(context)
        {

        }

        public Utilizator FindByUsername(string username)
        {
            return _table.FirstOrDefault(x => x.Username == username);
        }
    }
}
