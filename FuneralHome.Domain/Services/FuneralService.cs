using AutoMapper;
using FuneralHome.Data.Entities;
using FuneralHome.Data.Interfaces;
using FuneralHome.Data.Repositories;
using FuneralHome.Domain.Interfaces;
using FuneralHome.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace FuneralHome.Domain.Services
{
    public class FuneralService : IFuneralService
    {
        private readonly IMapper _mapper;
        private readonly IFuneralRepository<Funeral> _funeralRepository;
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
            _funeralRepository = new FuneralRepository(new Data.FuneralHomeContext());
        }

        public void Create(FuneralModel model)
        {
            var funeral = _mapper.Map<Funeral>(model);

            _funeralRepository.Create(funeral);
        }

        ICollection<FuneralModel> IFuneralService.GetAll()
        {
            var funerals = _funeralRepository.GetAll();

            return _mapper.Map<ICollection<FuneralModel>>(funerals);
        }

        public FuneralModel GetById(int id)
        {
            var funeral = _funeralRepository.GetById(id);

            return _mapper.Map<FuneralModel>(funeral);
        }

        public void Remove(FuneralModel item)
        {
            var funeral = _mapper.Map<Funeral>(item);

            _funeralRepository.Remove(funeral);

        }

        public void Update(FuneralModel entity, params Expression<Func<FuneralModel, object>>[] updatedProperties)
        {
            var funeral = _mapper.Map<Funeral>(updatedProperties);

            _funeralRepository.Update(funeral);
        }
    }
}
