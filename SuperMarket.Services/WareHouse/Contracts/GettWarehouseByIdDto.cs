using SuperMarket.Entites;
using System.Collections.Generic;

namespace SuperMarket.Services.WareHouse.Contracts
{
    public class GettWarehouseByIdDto
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
    }
}