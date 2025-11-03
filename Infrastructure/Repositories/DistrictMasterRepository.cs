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
    public class DistrictMasterRepository : Repository<DistrictMaster>, IDistrictMasterRepository
    {
        public DistrictMasterRepository(AppDbContext dbcontext):base(dbcontext) 
        {            
        }

        public async Task<string> CheckDuplicate(string dname, int id)
        {
            var query = _dbcontext.DistrictMaster.Where(x=> x.DistrictName.ToUpper() == dname.ToUpper());
            if(id>0)
            {
                query = query.Where(x=> x.Id! ==id);
            }
            bool IsDuplicate = await query.AnyAsync();
            return IsDuplicate ? "Yes" : "No";
        }

        public async Task<List<DistrictMasterCommon>> GetAll()
        {
            var disList = await (from dmaster in _dbcontext.DistrictMaster 
                                 join smaster in _dbcontext.StateMaster 
                                 on dmaster.SId equals smaster.Id into smasterjoin 
                                 from smaster in smasterjoin.DefaultIfEmpty()
                                 select new DistrictMasterCommon
                                 {
                                     Id = dmaster.Id,
                                     DistrictName=dmaster.DistrictName,
                                     StateName=smaster.StateName,
                                     
                                 }).ToListAsync();
            return disList;
        }

        public Task<List<DistrictMaster>> GetBySid(int sid)
        {
            var model = _dbcontext.DistrictMaster.Where(x=> x.SId==sid).ToListAsync();
            return model;
        }
    }
}
