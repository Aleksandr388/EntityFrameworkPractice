using FuneralHome.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Data.Interfaces
{
    public interface IFuneralRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        ICollection<Funeral> GetAll();
        Funeral GetById(int id);
        

    }
}
