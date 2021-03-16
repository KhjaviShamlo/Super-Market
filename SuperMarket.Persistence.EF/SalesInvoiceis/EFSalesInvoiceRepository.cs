using SuperMarket.Entites;
using SuperMarket.Services.SalesInvoiceis.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Persistence.EF.SalesInvoiceis
{
    public class EFSalesInvoiceRepository : SalesInvoiceRepository
    {
        public void Add(SalesInvoice salesInvoice)
        {
            throw new NotImplementedException();
        }

        public void Delete(SalesInvoice salesInvoice)
        {
            throw new NotImplementedException();
        }

        public Task<SalesInvoice> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<GettAllSalesInvoiceDto>> GettAll()
        {
            throw new NotImplementedException();
        }

        public Task<GettSalesInvoiceByIdDto> GettById(int id)
        {
            throw new NotImplementedException();
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
