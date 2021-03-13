using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperMarket.Entites;
namespace SuperMarket.Persistence.EF.GoodEntryMap
{
    public class GoodEntryEntityMap : IEntityTypeConfiguration<GoodEntry>
    {
        public void Configure(EntityTypeBuilder<GoodEntry> _)
        {
            _.ToTable("GoodEntries");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).ValueGeneratedOnAdd();
            _.Property(_ => _.GoodCode).IsRequired().HasMaxLength(10);
            _.Property(_ => _.GoodCount).IsRequired();
            _.Property(_ => _.EntryDate).IsRequired();
        }
    }
}
