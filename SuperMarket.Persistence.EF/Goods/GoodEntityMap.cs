using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Entites;
namespace SuperMarket.Persistence.EF.GoodsMap
{
    public class GoodEntityMap : IEntityTypeConfiguration<Good>
    {
        public void Configure(EntityTypeBuilder<Good> _)
        {
            _.ToTable("Goods");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Code).IsRequired().HasMaxLength(10);
            _.Property(_ => _.Count).IsRequired();
            _.Property(_ => _.Title).IsRequired().HasMaxLength(50);
        }
    }
}
