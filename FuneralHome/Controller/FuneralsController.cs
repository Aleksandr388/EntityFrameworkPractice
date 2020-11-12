using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FuneralHome.Domain.Interfaces;
using FuneralHome.Domain.Models;
using FuneralHome.Domain.Services;
using FuneralHome.Models.PostModel;
using FuneralHome.Models.ViewModel;

namespace FuneralHome.Controller
{
    public class FuneralsController 
    {
        private readonly IFuneralService _funeralService;
        private readonly IMapper _mapper;
        public FuneralsController()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FuneralModel, FuneralViewModel>().ReverseMap();
                cfg.CreateMap<ClientModel, ClientViewModel>().ReverseMap();
                cfg.CreateMap<EmployeeModel, EmployeeViewModel>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
            _funeralService = new FuneralService();
        }
        public IEnumerable<FuneralViewModel> GetAll()
        {
            var funerals = _funeralService.GetAll();

            return _mapper.Map<IEnumerable<FuneralViewModel>>(funerals);
        }

        
    }
}
