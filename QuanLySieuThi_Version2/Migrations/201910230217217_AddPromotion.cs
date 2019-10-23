namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPromotion : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PromotionProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PromotionProducts", "Promotion_Id", "dbo.Promotions");
            DropIndex("dbo.PromotionProducts", new[] { "Product_Id" });
            DropIndex("dbo.PromotionProducts", new[] { "Promotion_Id" });
            DropTable("dbo.PromotionProducts");
            DropTable("dbo.Promotions");
        }
    }
}
