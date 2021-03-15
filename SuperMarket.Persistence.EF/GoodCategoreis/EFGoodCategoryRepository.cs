using Microsoft.EntityFrameworkCore;
using SuperMarket.Entites;
using SuperMarket.Services.GoodCategores.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Persistence.EF.GoodCategoreis
{
    public class EFGoodCategoryRepository : GoodCategoryRepository
    {
        private readonly EFDataContext _context;
        private readonly DbSet<GoodCategory> _set;

        public EFGoodCategoryRepository(EFDataContext context)
        {
            _context = context;
            _set = _context.GoodCategores;
        }
        public void Add(GoodCategory goodCategores)
        {
            _set.Add(goodCategores);
        }

        public void Delete(GoodCategory goodCategory)
        {
            _set.Remove(goodCategory);
        }

        public async Task<GoodCategory> FindById(int id)
        {
           return await _set.FindAsync(id);
        }

        public async Task<IList<GettAllGoodCategoryDto>> GettAll()
        {
            return await _set.Select(c => new GettAllGoodCategoryDto()
            {
                Id = c.Id,
                Title = c.Title
            }).ToListAsync();
        }

        public async Task<GettGoodCategoryByIdDto> GettById(int id)
        {
            return await _set.Select(c => new GettGoodCategoryByIdDto()
            {
                Id = c.Id,
                Title = c.Title
            }).SingleOrDefaultAsync();
        }

        public async Task<bool> IsExistById(int id)
        {
            return await _set.AnyAsync(c => c.Id == id);
        }

        public async Task<bool> IsExistTitle(string title)
        {
            return await _set.AnyAsync(c => c.Title == title);
        }
    }
}
