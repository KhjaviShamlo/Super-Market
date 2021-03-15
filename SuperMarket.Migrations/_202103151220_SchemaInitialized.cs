using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
namespace SuperMarket.Migrations
{
    [Migration(202103151220)]
  public  class _202103151220_SchemaInitialized : FluentMigrator.Migration
    {
        public override void Down()
        {
            Delete.Table("Goods");
            Delete.Table("GoodCategores");
            Delete.Table("GoodEntries");
            Delete.Table("SalesFactors");
        }

        public override void Up()
        {
            Create.Table("GoodCategores")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Title").AsString().NotNullable();

            Create.Table("Warehouse").WithColumn("Id").AsInt32().Identity().PrimaryKey()
                   .WithColumn("Count").AsString().NotNullable()
                   .WithColumn("Name").AsString().NotNullable();

            Create.Table("Goods")
                .WithColumn("Id").AsInt32().Identity().NotNullable().PrimaryKey()
                .WithColumn("Code").AsString(10).NotNullable()
                .WithColumn("Title").AsString(50).NotNullable()
                .WithColumn("Count").AsInt32()
                .WithColumn("CategoryId").AsInt32().ForeignKey("FK_Goods_GoodsCategores", "GoodCategores", "Id")
                .WithColumn("WareHouseId").AsInt32().ForeignKey("FK_Goods_WareHouse", "Warehouse", "Id");

            Create.Table("GoodEntries")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("GoodCode").AsString().NotNullable()
                .WithColumn("GoodCount").AsInt32()
                .WithColumn("EntryDate").AsDateTime();

            Create.Table("SalesFactors")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("GoodCode").AsString(10).NotNullable()
                .WithColumn("GoodCount").AsInt32()
                .WithColumn("SalesDate").AsDateTime();
        }
    }
}
