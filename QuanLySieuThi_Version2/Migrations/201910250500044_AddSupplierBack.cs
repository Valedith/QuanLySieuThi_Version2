namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupplierBack : DbMigration
    {
        public override void Up()
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
            DropIndex("dbo.SupplierProducts", new[] { "Product_Id" });
            DropIndex("dbo.SupplierProducts", new[] { "Supplier_Id" });
            DropTable("dbo.SupplierProducts");
            DropTable("dbo.Suppliers");
        }
    }
}
