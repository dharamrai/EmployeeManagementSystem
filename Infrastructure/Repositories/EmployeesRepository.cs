using Domain.Models;
using Domain.RepositoryInterfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EmployeesRepository : Repository<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(AppDbContext dbcontext):base(dbcontext)
        {            
        }

        public async Task<List<EmployeesCommon>> GetAll()
        {
            var empList = await (from employees in _dbcontext.Employees
                                 join smaster in _dbcontext.StateMaster
                                 on employees.SId equals smaster.Id into smasterJoin
                                 from smaster in smasterJoin.DefaultIfEmpty()
                                 join dmaster in _dbcontext.DistrictMaster
                                 on employees.DId equals dmaster.Id into dmasterJoin
                                 from dmaster in dmasterJoin.DefaultIfEmpty()
                                 join deptmaster in _dbcontext.DepartmentMaster
                                 on employees.DeptId equals deptmaster.Id into deptMasterJoin
                                 from deptmaster in deptMasterJoin.DefaultIfEmpty()
                                 where employees.IsActive == true
                                 select new EmployeesCommon
                                 {
                                     Id = employees.Id,
                                     EName = employees.EName,
                                     Gender = employees.Gender,
                                     DOB = employees.DOB,
                                     DOJ = employees.DOJ,
                                     SId = employees.SId,
                                     DId = employees.DId,
                                     DeptId = employees.DeptId,
                                     ImgPath = employees.ImgPath,
                                     IsActive = employees.IsActive,
                                     Rating = employees.Rating,
                                     Salary = employees.Salary,
                                     // Custom
                                     StateName = smaster.StateName,
                                     DistrictName = dmaster.DistrictName,
                                     DepartmentName = deptmaster.Department
                                 }
                                 ).OrderByDescending( x => x.Id ).ToListAsync();
            return empList;
        }
    }
}
