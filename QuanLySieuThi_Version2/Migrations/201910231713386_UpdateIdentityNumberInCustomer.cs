namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdentityNumberInCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Salary_Id", "dbo.Salaries");
            DropIndex("dbo.Customers", new[] { "Name1" });
            DropIndex("dbo.Customers", new[] { "Salary_Id" });
            AddColumn("dbo.Customers", "IdentityNumber", c => c.String(nullable: false, maxLength: 9));
            CreateIndex("dbo.Customers", "IdentityNumber", unique: true);
            DropColumn("dbo.Customers", "Name1");
            DropColumn("dbo.Customers", "Salary_Id");
            DropTable("dbo.Salaries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Salary_Id", c => c.Int());
            AddColumn("dbo.Customers", "Name1", c => c.String(nullable: false, maxLength: 100));
            DropIndex("dbo.Customers", new[] { "IdentityNumber" });
            DropColumn("dbo.Customers", "IdentityNumber");
            CreateIndex("dbo.Customers", "Salary_Id");
            CreateIndex("dbo.Customers", "Name1", unique: true);
            AddForeignKey("dbo.Customers", "Salary_Id", "dbo.Salaries", "Id");
        }
    }
}
