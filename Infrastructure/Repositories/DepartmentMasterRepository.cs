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
    public class DepartmentMasterRepository:Repository<DepartmentMaster>, IDepartmentMasterRepository
    {
        public DepartmentMasterRepository(AppDbContext dbcontext):base(dbcontext)
        {            
        }

        public async Task<string> CheckDuplicate(string depname, int id)
        {
            var query = _dbcontext.DepartmentMaster.Where(x => x.Department.ToUpper() == depname.ToUpper());
            if (id > 0)
            {
                query = query.Where(x => x.Id! == id);
            }
            bool isDuplicate = await query.AnyAsync();
            return isDuplicate ? "Yes" : "No";
        }

    }
}
