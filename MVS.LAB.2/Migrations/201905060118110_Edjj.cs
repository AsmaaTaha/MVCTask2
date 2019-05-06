namespace MVS.LAB._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edjj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "DepartmentId", c => c.Int());
            CreateIndex("dbo.Employee", "DepartmentId");
            AddForeignKey("dbo.Employee", "DepartmentId", "dbo.Department", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DepartmentId", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "DepartmentId" });
            DropColumn("dbo.Employee", "DepartmentId");
        }
    }
}
