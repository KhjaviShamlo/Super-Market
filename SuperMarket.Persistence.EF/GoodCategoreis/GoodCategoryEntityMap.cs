using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Entites;
namespace SuperMarket.Persistence.EF.GoodCategoryMap
{
    class GoodCategoryEntityMap : IEntityTypeConfiguration<GoodCategory>
    {
        public void Configure(EntityTypeBuilder<GoodCategory> _)
        {
            _.ToTable("GoodCategores");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            _.Property(_ => _.Title).IsRequired();
            _.HasMany(_ => _.Goods).WithOne(_ => _.Category).HasForeignKey(_ => _.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
