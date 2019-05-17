namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMajors : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "Major_MajorID", newName: "Majors_MajorID");
            RenameIndex(table: "dbo.Courses", name: "IX_Major_MajorID", newName: "IX_Majors_MajorID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_Majors_MajorID", newName: "IX_Major_MajorID");
            RenameColumn(table: "dbo.Courses", name: "Majors_MajorID", newName: "Major_MajorID");
        }
    }
}
