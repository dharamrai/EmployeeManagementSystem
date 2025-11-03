using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IEmployeesRepository : IRepository<Employees>
    {
        Task<List<EmployeesCommon>> GetAll();
    }
}
