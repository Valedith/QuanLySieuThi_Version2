namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIsUniqueInProductType : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductTypes", new[] { "Name" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ProductTypes", "Name", unique: true);
        }
    }
}
