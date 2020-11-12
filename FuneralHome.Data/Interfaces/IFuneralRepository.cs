using FuneralHome.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Data.Interfaces
{
    public interface IFuneralRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllForDelegate(Func<TEntity, bool> predicate);
        void Create(TEntity item);
        ICollection<TEntity> GetAll();
        TEntity GetById(int id);
        void Remove(TEntity item);
        void Update(TEntity entity, params Expression<Func<TEntity, object>>[] updatedProperties);
    }
}
