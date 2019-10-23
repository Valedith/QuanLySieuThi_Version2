namespace QuanLySieuThi_Version2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Name1", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Customers", "Salary_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Name1", unique: true);
            CreateIndex("dbo.Customers", "Salary_Id");
            AddForeignKey("dbo.Customers", "Salary_Id", "dbo.Salaries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Salary_Id", "dbo.Salaries");
            DropIndex("dbo.Customers", new[] { "Salary_Id" });
            DropIndex("dbo.Customers", new[] { "Name1" });
            DropColumn("dbo.Customers", "Salary_Id");
            DropColumn("dbo.Customers", "Name1");
            DropTable("dbo.Salaries");
        }
    }
}
