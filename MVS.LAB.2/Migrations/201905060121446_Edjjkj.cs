namespace MVS.LAB._2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edjjkj : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employee", name: "DepartmentId", newName: "Dept_FK");
            RenameIndex(table: "dbo.Employee", name: "IX_DepartmentId", newName: "IX_Dept_FK");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employee", name: "IX_Dept_FK", newName: "IX_DepartmentId");
            RenameColumn(table: "dbo.Employee", name: "Dept_FK", newName: "DepartmentId");
        }
    }
}
