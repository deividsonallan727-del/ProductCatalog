using Microsoft.EntityFrameworkCore;
using ProductCatalog.Model.Context;
using ProductCatalog.Model.Entities;

namespace ProductCatalog.Repositories
{
    public class GenericRepositorie<TEntity> : IRepositorie<TEntity> where TEntity : BaseEntity
    {
        private Context _context { get; set; }
        private DbSet<TEntity> _dataset { get; set; }

        public GenericRepositorie(Context context)
        {
            _context = context;
            _dataset = _context.Set<TEntity>();
        }

        public List<TEntity> FindAll()
        {
            return _dataset.ToList();
        }

        public TEntity FindById(long id)
        {
            return _dataset.SingleOrDefault(e => e.Id == id);
        }

        public TEntity Create(TEntity entity)
        {
            try
            {
                _dataset.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the entity.", ex);
            }
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            try
            {
                _dataset.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the entity.", ex);
            }
            return entity;
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _dataset.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the entity.", ex);
            }
        }

        public bool Exists(long id)
        {
            return _dataset.Any(e => e.Id == id);
        }   
    }
}