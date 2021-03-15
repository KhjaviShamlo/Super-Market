using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Entites;
using System;
namespace SuperMarket.Persistence.EF.WareHouse
{
    public class WareHouseMap : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> _)
        {
            _.ToTable("WareHouseis");
            _.HasKey(_=>_.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Name).IsRequired();
            _.Property(_ => _.Count).IsRequired();
        }
    }
}
