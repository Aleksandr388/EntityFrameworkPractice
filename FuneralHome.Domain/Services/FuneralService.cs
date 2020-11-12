using AutoMapper;
using FuneralHome.Data.Entities;
using FuneralHome.Data.Interfaces;
using FuneralHome.Data.Repositories;
using FuneralHome.Domain.Interfaces;
using FuneralHome.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FuneralHome.Domain.Services
{
    public class FuneralService : IFuneralService
    {
        private readonly IMapper _mapper;
        private readonly IFuneralRepository _funeralRepository;
        private readonly IEmployeeRepository _employeeRepository;
        public FuneralService()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FuneralModel, Funeral>().ReverseMap();
                cfg.CreateMap<ClientModel, Client>().ReverseMap();
                cfg.CreateMap<Employee, EmployeeModel>()
                .ForMember(dest => dest.Position, opts => opts.MapFrom(x => x.PositionId))
                .ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
            _funeralRepository = new FuneralRepository();
            _employeeRepository = new EmployeeRepository();
        }

        public IEnumerable<FuneralModel> GetAll()
        {
            var funerals = _funeralRepository.GetAll();

            return _mapper.Map<IEnumerable<FuneralModel>>(funerals);
        }

        public FuneralModel Create(FuneralModel model)
        {
            return null;
        }
    }
}
