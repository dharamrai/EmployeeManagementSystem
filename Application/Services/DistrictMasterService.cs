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
    public class DistrictMasterService:Service<DistrictMaster, DistrictMasterDTO, DistrictMasterVM>, IDistrictMasterService
    {
        public DistrictMasterService(IUnitOfWork unitofwork, IMapper mapper, IRepository<DistrictMaster> repo)
            :base(unitofwork, mapper, repo) 
        {            
        }

        public async Task<string> CheckDuplicate(string dname, int id)
        {
            var result = await _unitOfWork.DistrictMasterRepository.CheckDuplicate(dname, id);
            return result;
        }

        public async Task<List<DistrictMasterCommonVM>> GetAll()
        {
           var model = await _unitOfWork.DistrictMasterRepository.GetAll();
            if (model == null) return null;
            var modelVm = _mapper.Map<List<DistrictMasterCommonVM>>(model); 
            return modelVm;
        }

        public async Task<List<DropDownStrVM>> GetDropDown()
        {
            var result = await _repo.Get();
            if (result == null) return null;
            var rmodelVm = _mapper.Map<List<DistrictMasterVM>>(result); 
            var modelDropdown = _mapper.Map<List<DropDownStrVM>>(rmodelVm);
            return modelDropdown;
        }

        public async Task<List<DropDownStrVM>> GetDropDownBySid(int sid)
        {
            if(sid == 0) return null;
            var model = await _unitOfWork.DistrictMasterRepository.GetBySid(sid);
            if (model == null) return null;
            var modelVm = _mapper.Map<List<DistrictMasterVM>>(model);
            var modelDropdown = _mapper.Map<List<DropDownStrVM>>(modelVm);
            return modelDropdown;
        }
    }
}
