using Application.ServiceInterfaces;
using AutoMapper;
using Domain.RepositoryInterfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Service<TModel, TDto, TVm>: IService<TModel, TDto, TVm> where TModel :class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        protected readonly IRepository<TModel> _repo;
        public Service(IUnitOfWork unitofwork, IMapper mapper, IRepository<TModel> repo)
        {
            _mapper = mapper;
            _unitOfWork = unitofwork;
            _repo = repo;
        }

        public async Task<List<TVm>> Get()
        {
            var result = await _repo.Get();
            if(result == null) return null;
            var modelVm = _mapper.Map<List<TVm>>(result);
            return modelVm;
        }

        public async Task<TDto> Get(int id)
        {
            var result = await _repo.Get(id);
            if (result == null) return default;
            var modelDto = _mapper.Map<TDto>(result);
            return modelDto;
        }

        public async Task<TDto> Create(TDto dto)
        {
            if (dto == null) return default;
            var model = _mapper.Map<TModel>(dto);
            _repo.Create(model);
            var rowChanges = await _unitOfWork.SaveChanges();
            if(rowChanges<=0) return default;
            var modelDto = _mapper.Map<TDto>(model);
            return modelDto;
        }

        public async Task<TDto> Update(TDto dto)
        {
            if (dto == null) return default;
            var model = _mapper.Map<TModel>(dto);
            _repo.Update(model);
            var rowChanges = await _unitOfWork.SaveChanges();
            if (rowChanges <= 0) return default;
            var modelDto = _mapper.Map<TDto>(model);
            return modelDto;
        }

        public async Task<int> Delete(int id)
        {
            if (id <= 0) return 0;
            var model = await _repo.Get(id);
            if (model == null) return 0;
            _repo.Delete(model);
            var rowChanges = await _unitOfWork.SaveChanges();
            return rowChanges;
        }

    }
}
