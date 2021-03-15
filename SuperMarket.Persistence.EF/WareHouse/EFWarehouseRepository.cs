using Microsoft.EntityFrameworkCore;
using SuperMarket.Entites;
using SuperMarket.Services.WareHouse.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Persistence.EF.SalesFactor
{
    public class EFWarehouseRepository : WareHouseRepository
    {
        private readonly EFDataContext _context;

        private readonly DbSet<Warehouse> _setWerhouse;
        public EFWarehouseRepository(EFDataContext context)
        {
            _context = context;
            _setWerhouse = _context.Warehouse;

        }
        public void Add(Warehouse wareHouse)
        {
            _setWerhouse.Add(wareHouse);
        }

        public void Delete(Warehouse wareHouse)
        {
            _setWerhouse.Remove(wareHouse);
        }

        public async Task<Warehouse> FindById(int id)
        {
           return await _setWerhouse.FindAsync(id);
        }

        public async Task<IList<GettAllWarehouseDto>> GettAll()
        {
            return await _setWerhouse.Select(c => new GettAllWarehouseDto()
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();
        }

        public Task<GettWarehouseByIdDto> GettById(int id)
        {
            return await _setWerhouse.Select(c => new GettWarehouseByIdDto()
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();
        }

        public Task<bool> IsExistById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
