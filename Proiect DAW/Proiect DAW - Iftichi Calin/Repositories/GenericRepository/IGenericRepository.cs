using Proiect_DAW___Iftichi_Calin.Models.Base;

namespace Proiect_DAW___Iftichi_Calin.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        //Get all data

        Task<List<TEntity>> GetAll();
        IQueryable<TEntity> GetAllAsQueryable();
        //IQueryable - tine minte query spre baza de date ; aduce datele filtrate
        //IEnumerable - executa query pe server dar incarca si toate datele in memorie -> abia apoi face filtrarile 
        //List -> tine datele

        //Create
        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        //Update

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);


        //Delete

        void Delete(TEntity entity);    
        void DeleteRange(IEnumerable<TEntity> entities);

        //Find
        TEntity FindById(object id);
        Task<TEntity> FindByIdAsync(object id);

        //Save

        bool Save();
        Task<bool> SaveAsync();
        
    }
}
