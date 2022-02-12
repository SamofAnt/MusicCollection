using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        AppDbContext _context;
        DbSet<TEntity> _dbSet;
        public EFGenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> filter) => _dbSet.AsNoTracking().Where(filter).ToList();

        public TEntity FindById(int id) => _dbSet.Find(id);

        public IEnumerable<TEntity> GetAll() => _dbSet.AsNoTracking().ToList();


        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
