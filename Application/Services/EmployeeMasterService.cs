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
    public class EmployeeMasterService : Service<Employees, EmployeesDTO, EmployeesVM>, IEmployeeService
    {
        public EmployeeMasterService(IUnitOfWork unitofwork, IMapper mapper, IRepository<Employees> repo)
            :base(unitofwork, mapper, repo) 
        {            
        }

        public async Task<List<EmployeesCommonVM>> GetAll()
        {
            var model = await _unitOfWork.EmployeesRepository.GetAll();
            if (model == null) return null;
            var modelVm = _mapper.Map<List<EmployeesCommonVM>>(model);
            return modelVm;
        }
    }
}
