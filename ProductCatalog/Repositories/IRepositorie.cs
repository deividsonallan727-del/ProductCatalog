using ProductCatalog.Model.Entities;


namespace ProductCatalog.Repositories
{
    public interface IRepositorie<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> FindAll();
        TEntity FindById(long id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        bool Exists(long id);
    }
}