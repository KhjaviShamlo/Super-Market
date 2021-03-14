using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
namespace SuperMarket.Migrations
{
    [Migration(20213131602)]
    class _20213131602_SchemaInitialized : Migration
    {
        public override void Down()
        {
            Create.Table("Goods").WithColumn("Id").AsInt32().Identity().NotNullable().PrimaryKey()
                .WithColumn("Code").AsString(10).NotNullable()
                .WithColumn("Title").AsString(50).NotNullable()
                .WithColumn("Count").AsInt32();
            Create.Table("GoodCategores").WithColumn("Id").AsInt32().PrimaryKey()
                .WithColumn("Title").AsString().Identity().NotNullable();
            Create.Table("GoodEntries").WithColumn("Id").AsString().Identity().PrimaryKey()
                .WithColumn("GoodCode").AsString().NotNullable()
                .WithColumn("GoodCount").AsInt32()
                .WithColumn("EntryDate").AsDateTime();
            Create.Table("SalesFactors").WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("GoodCode").AsString(10).NotNullable()
                .WithColumn("GoodCount").AsInt32()
                .WithColumn("SalesDate").AsDateTime();
        }

        public override void Up()
        {
            throw new NotImplementedException();
        }
    }
}
