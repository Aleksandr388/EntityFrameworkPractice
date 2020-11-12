using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuneralHome.Common.Enums;

namespace FuneralHome.Domain.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public EmplyeePositionEnum Position { get; set; }
        public IEnumerable<FuneralModel> Funerals { get; set; }
    }
}
