using FuneralHome.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    class Program
    {
        static void Main(string[] args) 
        {
            var ctrl = new FuneralsController();

            var model = ctrl.GetAll();

        }
    }
}
