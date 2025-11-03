using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IDistrictMasterRepository:IRepository<DistrictMaster>
    {
        Task<string> CheckDuplicate(string dname, int id);
        Task<List<DistrictMaster>> GetBySid(int sid);

        Task<List<DistrictMasterCommon>> GetAll();

        
    }
}
