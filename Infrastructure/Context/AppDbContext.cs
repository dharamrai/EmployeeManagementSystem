using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {            
        }

        public DbSet<StateMaster> StateMaster { get; set; }
        public DbSet<DistrictMaster> DistrictMaster { get; set; }
        public DbSet<DepartmentMaster> DepartmentMaster { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
