using FuneralHome.Data.Interfaces;
using FuneralHome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Domain.Interfaces
{
    public interface IFuneralService
    {
        void Create(FuneralModel item);
        ICollection<FuneralModel> GetAll();
        FuneralModel GetById(int id);
        void Remove(FuneralModel item);
        void Update(FuneralModel entity, params Expression<Func<FuneralModel, object>>[] updatedProperties);
    }
}