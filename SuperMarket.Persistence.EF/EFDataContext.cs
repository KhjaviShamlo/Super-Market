using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public EFDataContext(string connectionString) :this(new DbContextOptionsBuilder<EFDataContext>().UseSqlServer(connectionString).Options)
        {
        }

        private EFDataContext(DbContextOptions<EFDataContext> options)
            : this((DbContextOptions)options)
        {
        }

        protected EFDataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
        }
       
    }
}
