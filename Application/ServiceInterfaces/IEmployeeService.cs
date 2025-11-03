using Application.DTOs;
using Application.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IEmployeeService : IService<Employees, EmployeesDTO, EmployeesVM>
    {
        Task<List<EmployeesCommonVM>> GetAll();
    }
}
