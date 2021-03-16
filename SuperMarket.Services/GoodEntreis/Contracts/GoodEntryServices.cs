using SuperMarket.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Services.GoodEntreis.Contracts
{
    public interface GoodEntryServices
    {
        Task Add(GoodEntry goodEntry);
        Task Delete(GoodEntry goodEntry);
        Task<IList<GettGoodEntryDto>> GettAll();
        Task<GettGoodEntryByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<bool> IsExistTitle(string title);
        Task<GoodEntry> FindById(int id);
    }
}
