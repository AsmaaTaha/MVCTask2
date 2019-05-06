namespace MVS.LAB._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmnet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Employee", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "Salary", c => c.Int());
            DropTable("dbo.Departments");
        }
    }
}
