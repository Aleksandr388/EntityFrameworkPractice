using System.Collections.Generic;
using System.Linq;
using FuneralHome.Data.Entities;
using FuneralHome.Data.Interfaces;
using System.Data.Entity;

namespace FuneralHome.Data.Repositories
{
    public class FuneralRepository
    {
        private readonly FuneralHomeContext _ctx;

        public FuneralRepository()
        {
            _ctx = new FuneralHomeContext();
        }
        public ICollection<Funeral> GetAll()
        {
            return _ctx.Funerals
                .Include(x => x.Client)
                .Include(x => x.Employees)
                .AsNoTracking()
                .ToList();
        }

    }
}
