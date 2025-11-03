using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IDepartmentMasterRepository:IRepository<DepartmentMaster>
    {
        Task<string> CheckDuplicate(string depname, int id);
    }
}
