namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTeachInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherInfoes",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        OfficeLocation = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeacherInfoes");
        }
    }
}
