using Microsoft.EntityFrameworkCore;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Models.Base;

namespace Proiect_DAW___Iftichi_Calin.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ProiectContext _proiectContext;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(ProiectContext proiectContext)
        {
            _proiectContext = proiectContext;
            _table = _proiectContext.Set<TEntity>();
        }

        //GetAll

        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync(); //AsNoTracking -> cand iau datele din baza de date, fac modificari pe ele, dau save, nu va face update automat in baza de date
        }

        public IQueryable<TEntity> GetAllAsQueryable()
        {
            return _table.AsNoTracking().AsQueryable();
        }

        //Create
        public void Create(TEntity entity) 
        {
            _table.Add(entity);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities) 
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        //Update

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        //Delete

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        //Find

        public TEntity FindById(object id)
        {
            return _table.Find(id);
            //sau return _table.FirstOrDefault(x=>x.Id.Equals(id));
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            return await _table.FindAsync(id);
            //return await _table.FirstOrDefault(x=>x.Id.Equals(id));
        }

        //Save
        public bool Save()
        {
            return _proiectContext.SaveChanges() > 0; //daca s-au facut modificari
        }

        public async Task<bool> SaveAsync()
        {
            return await _proiectContext.SaveChangesAsync() > 0;
        }

    }
}
