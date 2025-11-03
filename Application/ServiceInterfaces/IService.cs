using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IService<TModel, TDto, TVm> where TModel : class
    {
        Task<List<TVm>> Get();
        Task<TDto> Get(int id);
        Task<TDto> Create(TDto dto);
        Task<TDto> Update(TDto dto);
        Task<int> Delete(int id);
    }
}
