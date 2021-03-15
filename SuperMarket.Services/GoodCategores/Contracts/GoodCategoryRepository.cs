using SuperMarket.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.GoodCategores.Contracts
{
    public interface GoodCategoryRepository
    {
        void Add(GoodCategory goodCategores);
        void Delete(GoodCategory goodCategory);
        Task<IList<GettAllGoodCategoryDto>> GettAll();
        Task<GettGoodCategoryByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<bool> IsExistTitle(string title);
        Task<GoodCategory> FindById(int id);
    }
}
