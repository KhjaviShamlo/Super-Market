using Microsoft.EntityFrameworkCore;
using SuperMarket.Entites;
using SuperMarket.Services.GoodEntreis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Persistence.EF.GoodEntreis
{
    public class EFGoodEntreisRepository : GoodEntryRepository
    {
        private readonly EFDataContext _context;
        private readonly DbSet<GoodEntry> _setGoodEntry;
        public EFGoodEntreisRepository(EFDataContext context)
        {
            _context = context;
            _setGoodEntry = _context.GoodEntries;
        }
        public void Add(GoodEntry goodEntry)
        {
            _setGoodEntry.Add(goodEntry);
        }

        public void Delete(GoodEntry goodEntry)
        {
            _setGoodEntry.Remove(goodEntry);
        }

        public async Task<GoodEntry> FindById(int id)
        {
            return await _setGoodEntry.FindAsync(id);
        }

        public async Task<IList<GettGoodEntryDto>> GettAll()
        {
            return await _setGoodEntry.Select(c => new GettGoodEntryDto()
            {
                EntryDate = c.EntryDate,
                GoodCode = c.GoodCode,
                GoodCount = c.GoodCount
            }).ToListAsync();
        }

        public async Task<GettGoodEntryByIdDto> GettById(int id)
        {
            return await _setGoodEntry.Select(c => new GettGoodEntryByIdDto()
            {
                Id = c.Id
            }).SingleOrDefaultAsync();
        }

        public async Task<bool> IsExistById(int id)
        {
            return await _setGoodEntry.AnyAsync(c => c.Id == id);
        }

    }
}
