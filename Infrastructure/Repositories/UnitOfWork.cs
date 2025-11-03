using Domain.RepositoryInterfaces;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStateMasterRepository StateMasterRepository { get; }
        public IDistrictMasterRepository DistrictMasterRepository { get; }
        public IDepartmentMasterRepository DepartmentMasterRepository { get; }
        public IEmployeesRepository EmployeesRepository { get; }
        private readonly AppDbContext _dbcontext;
        public UnitOfWork(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            StateMasterRepository = new StateMasterRepository(dbcontext);
            DistrictMasterRepository = new DistrictMasterRepository(dbcontext);
            DepartmentMasterRepository = new DepartmentMasterRepository(dbcontext);
            EmployeesRepository = new EmployeesRepository(dbcontext);
        }

        public void Dispose()
        {
           _dbcontext.Dispose();
        }

        public Task<int> SaveChanges()
        {
           return _dbcontext.SaveChangesAsync();
        }
    }
}
