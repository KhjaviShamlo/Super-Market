using Microsoft.EntityFrameworkCore;
using SuperMarket.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Persistence.EF
{
    public class EFDataContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodCategory> GoodCategores { get; set; }
        public DbSet<GoodEntry> GoodEntries { get; set; }
        public DbSet<SalesFactor> SalesFactors { get; set; }
        public EFDataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
