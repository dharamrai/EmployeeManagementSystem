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
    public class StateMasterRepository :Repository<StateMaster>, IStateMasterRepository
    {
        public StateMasterRepository(AppDbContext dbcontext):base(dbcontext)
        {            
        }

        public async Task<string> CheckDuplicate(string sname, int id)
        {
            var result = _dbcontext.StateMaster.Where(x => x.StateName.ToUpper() == sname.ToUpper());
            if(id>0)
            {
                result = result.Where(x=> x.Id! == id);
            }

            bool isDuplicate = await result.AnyAsync();
            return isDuplicate ? "Yes" : "No";
        }
    }
}
