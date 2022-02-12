using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public interface IGenericRepository<TEntity> 
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> filter);
        TEntity FindById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
