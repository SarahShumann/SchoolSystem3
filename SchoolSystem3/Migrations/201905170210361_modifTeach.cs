namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifTeach : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TeacherInfoes");
            AlterColumn("dbo.TeacherInfoes", "TeacherID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TeacherInfoes", "TeacherID");
            CreateIndex("dbo.TeacherInfoes", "TeacherID");
            AddForeignKey("dbo.TeacherInfoes", "TeacherID", "dbo.Teachers", "TeacherID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherInfoes", "TeacherID", "dbo.Teachers");
            DropIndex("dbo.TeacherInfoes", new[] { "TeacherID" });
            DropPrimaryKey("dbo.TeacherInfoes");
            AlterColumn("dbo.TeacherInfoes", "TeacherID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TeacherInfoes", "TeacherID");
        }
    }
}
