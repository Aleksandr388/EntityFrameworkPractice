using FuneralHome.Data.Entities;
using FuneralHome.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FuneralHomeContext _ctx;

        public EmployeeRepository()
        {
            _ctx = new FuneralHomeContext();
        }

        IEnumerable<Funeral> IEmployeeRepository.GetByDate(IEnumerable<int> employeeIds)
        {
            return (IEnumerable<Funeral>)_ctx.Employees
                .Include(x => x.Funerals)
                .Where(x => employeeIds.Contains(x.Id))
                .AsNoTracking()
                .ToList();
        }
    }
}
