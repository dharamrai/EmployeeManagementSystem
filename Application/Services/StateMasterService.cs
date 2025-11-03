using Application.DTOs;
using Application.ServiceInterfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class StateMasterService :Service<StateMaster, StateMasterDTO, StateMasterVM>, IStateMasterService
    {
        public StateMasterService(IUnitOfWork unitofwork, IMapper mapper, IRepository<StateMaster> repo)
            :base(unitofwork, mapper, repo)
        {            
        }

        public async Task<string> CheckDuplicate(string sname, int id)
        {
            var result = await _unitOfWork.StateMasterRepository.CheckDuplicate(sname, id);
            return result;
        }

        public async Task<List<DropDownStrVM>> GetDropDown()
        {
            var model = await _repo.Get();
            if (model == null) return null;
            var modelVm = _mapper.Map<List<StateMasterVM>>(model);
            var modelDropdown = _mapper.Map<List<DropDownStrVM>>(modelVm);
            return modelDropdown;
        }

      
    }
}
