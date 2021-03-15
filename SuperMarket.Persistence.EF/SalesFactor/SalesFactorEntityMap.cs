
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Entites;

namespace SuperMarket.Persistence.EF.SalesFactorMa
{
    public class SalesFactorEntityMap : IEntityTypeConfiguration<SalesFactor>
    {
        public void Configure(EntityTypeBuilder<SalesFactor> _)
        {
            _.ToTable("SalesFactors");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.GoodCode).IsRequired().HasMaxLength(10);
            _.Property(_ => _.GoodCount).IsRequired();
            _.Property(_ => _.SalesDate).IsRequired();
        }
    }
}
