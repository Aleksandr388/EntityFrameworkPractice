﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralHome.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Number { get; set; }
        public int? DeathCertificateNumber { get; set; }
        public ICollection<Funeral> Funerals { get; set; }
    }
}
