using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.GoodCategores.Contracts
{
    public interface GoodCategoryRepository
    {
        void Add();
        void Delete();
        Task<IList<GettAllGoodCategoryDto>> GettAll();
        Task<GettGoodCategoryByIdDto> GettById();
        Task<bool> IsExistById(int id);
    }
}
