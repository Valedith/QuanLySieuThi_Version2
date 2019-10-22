namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProductProductTypeRelaptionship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductTypeProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductTypeProducts", "ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.ProductTypeProducts", new[] { "ProductTypeId" });
            DropIndex("dbo.ProductTypeProducts", new[] { "ProductId" });
            DropTable("dbo.ProductTypeProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductTypeProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductTypeId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProductTypeProducts", "ProductId");
            CreateIndex("dbo.ProductTypeProducts", "ProductTypeId");
            AddForeignKey("dbo.ProductTypeProducts", "ProductTypeId", "dbo.ProductTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductTypeProducts", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
