namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAllExceptProductAndProductBrand_FixedBugs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductTypeProducts", "ProductType_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductTypeProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PromotionProducts", "Promotion_Id", "dbo.Promotions");
            DropForeignKey("dbo.PromotionProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.SupplierProducts", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierProducts", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductTypes", new[] { "Name" });
            DropIndex("dbo.ProductTypeProducts", new[] { "ProductType_Id" });
            DropIndex("dbo.ProductTypeProducts", new[] { "Product_Id" });
            DropIndex("dbo.PromotionProducts", new[] { "Promotion_Id" });
            DropIndex("dbo.PromotionProducts", new[] { "Product_Id" });
            DropIndex("dbo.SupplierProducts", new[] { "Supplier_Id" });
            DropIndex("dbo.SupplierProducts", new[] { "Product_Id" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Promotions");
            DropTable("dbo.Suppliers");
            DropTable("dbo.ProductTypeProducts");
            DropTable("dbo.PromotionProducts");
            DropTable("dbo.SupplierProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SupplierProducts",
                c => new
                    {
                        Supplier_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_Id, t.Product_Id });
            
            CreateTable(
                "dbo.PromotionProducts",
                c => new
                    {
                        Promotion_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Promotion_Id, t.Product_Id });
            
            CreateTable(
                "dbo.ProductTypeProducts",
                c => new
                    {
                        ProductType_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductType_Id, t.Product_Id });
            
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
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.SupplierProducts", "Product_Id");
            CreateIndex("dbo.SupplierProducts", "Supplier_Id");
            CreateIndex("dbo.PromotionProducts", "Product_Id");
            CreateIndex("dbo.PromotionProducts", "Promotion_Id");
            CreateIndex("dbo.ProductTypeProducts", "Product_Id");
            CreateIndex("dbo.ProductTypeProducts", "ProductType_Id");
            CreateIndex("dbo.ProductTypes", "Name", unique: true);
            AddForeignKey("dbo.SupplierProducts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SupplierProducts", "Supplier_Id", "dbo.Suppliers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PromotionProducts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PromotionProducts", "Promotion_Id", "dbo.Promotions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductTypeProducts", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductTypeProducts", "ProductType_Id", "dbo.ProductTypes", "Id", cascadeDelete: true);
        }
    }
}
