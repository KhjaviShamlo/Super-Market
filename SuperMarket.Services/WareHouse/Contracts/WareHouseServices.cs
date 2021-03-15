using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.WareHouse.Contracts
{
   public interface WareHouseServices
    {
        Task Add(AddWarehouseDto dto);
        Task Update(int id, UpdateWarehouseDto dto);
        Task Delete(int id);
        Task<IList<GettAllWarehouseDto>> GetAll();
        Task<GettWarehouseByIdDto> GettById(int id);
    }
}
