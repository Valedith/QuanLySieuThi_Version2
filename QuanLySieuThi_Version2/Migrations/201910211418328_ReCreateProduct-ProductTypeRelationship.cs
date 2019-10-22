namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReCreateProductProductTypeRelationship : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTypeProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductTypeProducts", "ProductType_Id", "dbo.ProductTypes");
            DropIndex("dbo.ProductTypeProducts", new[] { "Product_Id" });
            DropIndex("dbo.ProductTypeProducts", new[] { "ProductType_Id" });
            DropTable("dbo.ProductTypeProducts");
        }
    }
}
