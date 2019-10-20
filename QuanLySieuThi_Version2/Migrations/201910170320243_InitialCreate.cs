namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductBrands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Detail = c.String(maxLength: 450),
                        ProductBrandId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductBrands", t => t.ProductBrandId, cascadeDelete: true)
                .Index(t => t.ProductBrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductBrandId", "dbo.ProductBrands");
            DropIndex("dbo.Products", new[] { "ProductBrandId" });
            DropIndex("dbo.ProductBrands", new[] { "Name" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductBrands");
        }
    }
}
