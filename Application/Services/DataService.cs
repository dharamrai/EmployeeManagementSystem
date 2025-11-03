using Application.ServiceInterfaces;
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
    public class DataService : IDataService
    {
        public IStateMasterService StateMasterService { get; }
        public IDistrictMasterService DistrictMasterService { get; }
        public IDepartmentMasterService DepartmentMasterService { get; }
        public IEmployeeService EmployeeMasterService { get; }

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DataService(IUnitOfWork unitofwork, IMapper mapper, IRepository<StateMaster> stateRepo,
            IRepository<DistrictMaster> disRepo, IRepository<DepartmentMaster> deptRepo, 
            IRepository<Employees> empRepo)
        {
            _unitOfWork = unitofwork;
            _mapper = mapper;
            StateMasterService = new StateMasterService(unitofwork, mapper, stateRepo);
            DistrictMasterService = new DistrictMasterService(unitofwork, mapper, disRepo);
            DepartmentMasterService = new DepartmentMasterService(unitofwork, mapper, deptRepo);
            EmployeeMasterService = new EmployeeMasterService(unitofwork, mapper, empRepo);
        }

        
    }
}
