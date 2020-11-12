using FuneralHome.Controller;
using FuneralHome.Models.PostModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuneralHome.Common.Enums;
using FuneralHome.Models.ViewModel;

namespace EntityFrameworkPractice
{
    class Program
    {
        static void Main(string[] args) 
        {
            var ctrl = new FuneralsController();


            var model = new FuneralViewModel
            {
                DateUtc = DateTime.Now,
                Type = (FuneralTypeEnum)2,
            };

            var getAll = ctrl.GetAll();

            var getId = ctrl.GetById(2);

            //var update = ctrl.Update(model);

            //ctrl.Create(model);
        }
    }
}
