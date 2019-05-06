namespace MVS.LAB._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departments", newName: "Department");
            AddColumn("dbo.Employee", "Gender", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Gender");
            RenameTable(name: "dbo.Department", newName: "Departments");
        }
    }
}
