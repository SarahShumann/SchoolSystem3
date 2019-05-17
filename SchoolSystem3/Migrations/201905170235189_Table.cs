namespace SchoolSystem3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.TeacherCourses", "Course_CourseID", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "CourseID");
            AddForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
            AddForeignKey("dbo.TeacherCourses", "Course_CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherCourses", "Course_CourseID", "dbo.Courses");
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Courses", "CourseID");
            AddForeignKey("dbo.TeacherCourses", "Course_CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
    }
}
