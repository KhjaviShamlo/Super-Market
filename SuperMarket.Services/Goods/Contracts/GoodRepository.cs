using SuperMarket.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.Goods.Contracts
{
    public interface GoodRepository
    {
        void Add(RegisterGoodDto dto);
        void Delete(Good good);
        Task<IList<GetAllGoodsDto>> GetAll();
        Task<FindGoodByIdDto> FindById(int id);
    }
}
