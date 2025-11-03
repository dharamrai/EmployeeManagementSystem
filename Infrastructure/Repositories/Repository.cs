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
    public class Repository<TModel>:IRepository<TModel> where TModel : class
    {
        protected readonly AppDbContext _dbcontext;
        public Repository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Task<List<TModel>> Get()
        {
            return _dbcontext.Set<TModel>().ToListAsync();
        }

        public Task<TModel> Get(int id)
        {
            return _dbcontext.Set<TModel>().FindAsync(id).AsTask();
        }
        public void Create(TModel model)
        {
            _dbcontext.Set<TModel>().AddAsync(model);
        }

        public void Update(TModel model)
        {
           _dbcontext.Set<TModel>().Update(model);
        }

        public void Delete(TModel model)
        {
           _dbcontext.Set<TModel>().Remove(model);
        }

        
    }
}
