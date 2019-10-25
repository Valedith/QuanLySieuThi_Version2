namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSupplier : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SupplierProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplierProducts", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.SupplierProducts", new[] { "SupplierId" });
            DropIndex("dbo.SupplierProducts", new[] { "ProductId" });
            DropTable("dbo.SupplierProducts");
            DropTable("dbo.Suppliers");
        }
        
        public override void Down()
        {
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
                "dbo.SupplierProducts",
                c => new
                    {
                        SupplierProductId = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        IsSupplying = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierProductId);
            
            CreateIndex("dbo.SupplierProducts", "ProductId");
            CreateIndex("dbo.SupplierProducts", "SupplierId");
            AddForeignKey("dbo.SupplierProducts", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SupplierProducts", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
