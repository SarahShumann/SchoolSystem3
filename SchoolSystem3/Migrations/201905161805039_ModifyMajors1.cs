namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMajors1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Majors_MajorID", "dbo.Majors");
            DropIndex("dbo.Courses", new[] { "Majors_MajorID" });
            RenameColumn(table: "dbo.Courses", name: "Majors_MajorID", newName: "MajorID");
            AlterColumn("dbo.Courses", "MajorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "MajorID");
            AddForeignKey("dbo.Courses", "MajorID", "dbo.Majors", "MajorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "MajorID", "dbo.Majors");
            DropIndex("dbo.Courses", new[] { "MajorID" });
            AlterColumn("dbo.Courses", "MajorID", c => c.Int());
            RenameColumn(table: "dbo.Courses", name: "MajorID", newName: "Majors_MajorID");
            CreateIndex("dbo.Courses", "Majors_MajorID");
            AddForeignKey("dbo.Courses", "Majors_MajorID", "dbo.Majors", "MajorID");
        }
    }
}
