namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Promotion_Supplier_PRoductType_Back : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        DiscountRate = c.Single(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 200),
                        PhoneNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductTypeProducts",
                c => new
                    {
                        ProductType_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductType_Id, t.Product_Id })
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.ProductType_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.PromotionProducts",
                c => new
                    {
                        Promotion_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Promotion_Id, t.Product_Id })
                .ForeignKey("dbo.Promotions", t => t.Promotion_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Promotion_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.SupplierProducts",
                c => new
                    {
                        Supplier_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_Id, t.Product_Id })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Supplier_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.SupplierProducts", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.PromotionProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PromotionProducts", "Promotion_Id", "dbo.Promotions");
            DropForeignKey("dbo.ProductTypeProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductTypeProducts", "ProductType_Id", "dbo.ProductTypes");
            DropIndex("dbo.SupplierProducts", new[] { "Product_Id" });
            DropIndex("dbo.SupplierProducts", new[] { "Supplier_Id" });
            DropIndex("dbo.PromotionProducts", new[] { "Product_Id" });
            DropIndex("dbo.PromotionProducts", new[] { "Promotion_Id" });
            DropIndex("dbo.ProductTypeProducts", new[] { "Product_Id" });
            DropIndex("dbo.ProductTypeProducts", new[] { "ProductType_Id" });
            DropIndex("dbo.ProductTypes", new[] { "Name" });
            DropTable("dbo.SupplierProducts");
            DropTable("dbo.PromotionProducts");
            DropTable("dbo.ProductTypeProducts");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Promotions");
            DropTable("dbo.ProductTypes");
        }
    }
}
