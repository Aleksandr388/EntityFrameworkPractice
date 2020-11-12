using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Create(FuneralViewModel model)
        {
            var funeral = _mapper.Map<FuneralModel>(model);

            _funeralService.Create(funeral);
        }

        public FuneralViewModel GetById(int id)
        {
            var funeral = _funeralService.GetById(id);

            return _mapper.Map<FuneralViewModel>(funeral);
        }

        public void Remove(FuneralViewModel item)
        {
            var funeral = _mapper.Map<FuneralModel>(item);

            _funeralService.Remove(funeral);

        }

        public void Update(FuneralViewModel entity, params Expression<Func<FuneralModel, object>>[] updatedProperties)
        {
            var funeral = _mapper.Map<FuneralModel>(updatedProperties);

            _funeralService.Update(funeral);
        }
    }
}
