using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStateMasterRepository StateMasterRepository { get; }
        IDistrictMasterRepository DistrictMasterRepository { get; }
        IDepartmentMasterRepository DepartmentMasterRepository { get; }
        IEmployeesRepository EmployeesRepository { get; }
        Task<int> SaveChanges();
    }
}
