namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIsUniqueInProductBrand : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductBrands", new[] { "Name" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ProductBrands", "Name", unique: true);
        }
    }
}
