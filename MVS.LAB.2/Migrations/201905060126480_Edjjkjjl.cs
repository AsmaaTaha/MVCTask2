namespace MVS.LAB._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edjjkjjl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "Dept_FK", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "Dept_FK" });
            AlterColumn("dbo.Employee", "Dept_FK", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "Dept_FK");
            AddForeignKey("dbo.Employee", "Dept_FK", "dbo.Department", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "Dept_FK", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "Dept_FK" });
            AlterColumn("dbo.Employee", "Dept_FK", c => c.Int());
            CreateIndex("dbo.Employee", "Dept_FK");
            AddForeignKey("dbo.Employee", "Dept_FK", "dbo.Department", "Id");
        }
    }
}
