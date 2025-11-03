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
    public class DepartmentMasterService:Service<DepartmentMaster, DepartmentMasterDTO, DepartmentMasterVM>, IDepartmentMasterService
    {
        public DepartmentMasterService(IUnitOfWork unitofwork, IMapper mapper, IRepository<DepartmentMaster> repo)
            :base(unitofwork, mapper, repo) 
        {
            
        }

        public async Task<string> CheckDuplicate(string depname, int id)
        {
            var result = await _unitOfWork.DepartmentMasterRepository.CheckDuplicate(depname, id);
            return result;
        }

        public async Task<List<DropDownStrVM>> GetDropDown()
        {
            var result = await _repo.Get();
            if (result == null) return null;
            var modelVm = _mapper.Map<List<DepartmentMasterVM>>(result);
            var modelDropdown = _mapper.Map<List<DropDownStrVM>>(modelVm);
            return modelDropdown;
        }
    }
}
