using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Data.Entities
{
    public class Funeral
    {
        public int Id { get; set; }
        public DateTime DateUtc { get; set; }
        public int Type { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
