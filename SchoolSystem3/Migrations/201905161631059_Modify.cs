namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modify : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        MajorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TeacherID = c.Int(),
                    })
                .PrimaryKey(t => t.MajorID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.TeacherCourses",
                c => new
                    {
                        Teacher_TeacherID = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherID, t.Course_CourseID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseID, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherID)
                .Index(t => t.Course_CourseID);
            
            AddColumn("dbo.Courses", "Major_MajorID", c => c.Int());
            AlterColumn("dbo.Courses", "CourseID", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "EnrollmentDate", c => c.DateTime());
            AddPrimaryKey("dbo.Courses", "CourseID");
            CreateIndex("dbo.Courses", "Major_MajorID");
            AddForeignKey("dbo.Courses", "Major_MajorID", "dbo.Majors", "MajorID");
            AddForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Majors", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Courses", "Major_MajorID", "dbo.Majors");
            DropForeignKey("dbo.TeacherCourses", "Course_CourseID", "dbo.Courses");
            DropForeignKey("dbo.TeacherCourses", "Teacher_TeacherID", "dbo.Teachers");
            DropIndex("dbo.TeacherCourses", new[] { "Course_CourseID" });
            DropIndex("dbo.TeacherCourses", new[] { "Teacher_TeacherID" });
            DropIndex("dbo.Majors", new[] { "TeacherID" });
            DropIndex("dbo.Courses", new[] { "Major_MajorID" });
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Students", "EnrollmentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "CourseID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Courses", "Major_MajorID");
            DropTable("dbo.TeacherCourses");
            DropTable("dbo.Majors");
            DropTable("dbo.Teachers");
            AddPrimaryKey("dbo.Courses", "CourseID");
            AddForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
    }
}
