namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherInfoes",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            AddColumn("dbo.Teachers", "TeacherInfo_TeacherID", c => c.Int());
            CreateIndex("dbo.Teachers", "TeacherInfo_TeacherID");
            AddForeignKey("dbo.Teachers", "TeacherInfo_TeacherID", "dbo.TeacherInfoes", "TeacherID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "TeacherInfo_TeacherID", "dbo.TeacherInfoes");
            DropIndex("dbo.Teachers", new[] { "TeacherInfo_TeacherID" });
            DropColumn("dbo.Teachers", "TeacherInfo_TeacherID");
            DropTable("dbo.TeacherInfoes");
        }
    }
}
