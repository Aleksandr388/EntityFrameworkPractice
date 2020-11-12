using FuneralHome.Data.Entities;
using FuneralHome.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace FuneralHome.Data.Repositories
{
    public class FuneralReposytoryBase<TEntity> : IFuneralRepository<TEntity> where TEntity : class
    {

        DbContext _context;
        DbSet<TEntity> _ctx;

        public FuneralReposytoryBase(DbContext context)
        {
            _context = context;
            _ctx = context.Set<TEntity>();
        }

        public void Create(TEntity item)
        {
            _ctx.Add(item);
            _context.SaveChanges();
        }

        public ICollection<TEntity> GetAll()
        {
            return _ctx.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> GetAllForDelegate(Func<TEntity, bool> predicate)
        {
            return _ctx.AsNoTracking().Where(predicate).ToList();
        }

        public TEntity GetById(int id)
        {
            return _ctx.Find(id);
        }

        public void Remove(TEntity item)
        {
            _ctx.Remove(item);
            _context.SaveChanges();
        }
        public void Update(TEntity entity, params Expression<Func<TEntity, object>>[] updatedProperties)
        {
            var dbEntityEntry = _context.Entry(entity);
            if (updatedProperties.Any())
            {
                foreach (var property in updatedProperties)
                {
                    dbEntityEntry.Property(property).IsModified = true;
                }
            }
            else
            {
                foreach (var property in dbEntityEntry.OriginalValues.PropertyNames)
                {
                    var original = dbEntityEntry.OriginalValues.GetValue<object>(property);
                    var current = dbEntityEntry.CurrentValues.GetValue<object>(property);
                    if (original != null && !original.Equals(current))
                        dbEntityEntry.Property(property).IsModified = true;
                }
            }
        }


    }
}
