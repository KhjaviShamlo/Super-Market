using SuperMarket.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.GoodEntreis
{
  public interface  GoodEntryRepository
    {
        void Add(GoodEntry goodEntry);
        void Delete(GoodEntry goodEntry);
        Task<IList<GettGoodEntryDto>> GettAll();
        Task<GettGoodEntryDtoByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<bool> IsExistTitle(string title);
        Task<GoodEntry> FindById(int id);
    }
}
