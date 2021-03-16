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
        private readonly DbSet<GoodCategory> _setGoodCategory;

        public EFGoodCategoryRepository(EFDataContext context)
        {
            _context = context;
            _setGoodCategory = _context.GoodCategores;
        }
        public void Add(GoodCategory goodCategores)
        {
            _setGoodCategory.Add(goodCategores);
        }

        public void Delete(GoodCategory goodCategory)
        {
            _setGoodCategory.Remove(goodCategory);
        }

        public async Task<GoodCategory> FindById(int id)
        {
           return await _setGoodCategory.FindAsync(id);
        }

        public async Task<IList<GettAllGoodCategoryDto>> GettAll()
        {
            return await _setGoodCategory.Select(c => new GettAllGoodCategoryDto()
            {
                Id = c.Id,
                Title = c.Title
            }).ToListAsync();
        }

        public async Task<GettGoodCategoryByIdDto> GettById(int id)
        {
            return await _setGoodCategory.Select(c => new GettGoodCategoryByIdDto()
            {
                Id = c.Id,
                Title = c.Title
            }).SingleOrDefaultAsync();
        }

        public async Task<bool> IsExistById(int id)
        {
            return await _setGoodCategory.AnyAsync(c => c.Id == id);
        }

        public async Task<bool> IsExistTitle(string title)
        {
            return await _setGoodCategory.AnyAsync(c => c.Title == title);
        }
    }
}
