using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.GoodCategores.Contracts
{
    public interface GoodCategoryServices
    {
        Task Add(AddGoodCategoryDto dto);
        Task Update(int id,UpdateGoodCategoryDto dto);
        Task Delete(int id);
        Task<IList<GettAllGoodCategoryDto>> GetAll();
        Task<GettGoodCategoryByIdDto> GettById(int id);
    }
}
