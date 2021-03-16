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
        Task<GettGoodEntryByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<GoodEntry> FindById(int id);
    }
}
