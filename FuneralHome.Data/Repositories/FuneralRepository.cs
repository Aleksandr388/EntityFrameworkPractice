using System.Collections.Generic;
using System.Linq;
using FuneralHome.Data.Entities;
using FuneralHome.Data.Interfaces;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

namespace FuneralHome.Data.Repositories
{
    public class FuneralRepository : FuneralReposytoryBase<Funeral>
    { 
        private readonly FuneralHomeContext _ctx;

        public FuneralRepository(FuneralHomeContext context) : base(context)
        {
            _ctx = context;
        }
    }
}
