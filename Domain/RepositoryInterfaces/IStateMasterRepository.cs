using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IStateMasterRepository:IRepository<StateMaster>
    {
        Task<string> CheckDuplicate(string sname, int id);
    }
}
