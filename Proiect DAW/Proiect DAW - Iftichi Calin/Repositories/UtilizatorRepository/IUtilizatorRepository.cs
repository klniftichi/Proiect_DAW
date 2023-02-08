using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Repositories.GenericRepository;

namespace Proiect_DAW___Iftichi_Calin.Repositories.UtilizatorRepository
{
    public interface IUtilizatorRepository : IGenericRepository<Utilizator>
    {
        Utilizator FindByUsername(string username);

    }
}
