namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniquesBack : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ProductBrands", "Name", unique: true);
            CreateIndex("dbo.ProductTypes", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductTypes", new[] { "Name" });
            DropIndex("dbo.ProductBrands", new[] { "Name" });
        }
    }
}
