using FuneralHome.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Models.PostModel
{
    public class FuneralPostModel
    {
        public DateTime Date { get; set; }
        public FuneralTypeEnum Type { get; set; }
        public int ClientId { get; set; }
        public ClientPostModel Client { get; set; }
        public IEnumerable<int> EmployeesId { get; set; }

    }
}
