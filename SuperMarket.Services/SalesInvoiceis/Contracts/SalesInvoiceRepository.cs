using SuperMarket.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace SuperMarket.Services.SalesInvoiceis.Contracts
{
    public interface SalesInvoiceRepository
    {
        void Add(SalesInvoice salesInvoice);
        void Delete(SalesInvoice salesInvoice);
        Task<IList<GettAllSalesInvoiceDto>> GettAll();
        Task<GettSalesInvoiceByIdDto> GettById(int id);
        Task<bool> IsExistById(int id);
        Task<bool> IsExistTitle(string title);
        Task<SalesInvoice> FindById(int id);
    }
}
