namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test33 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lecturer_Id");
            AddColumn("dbo.Courses", "LecturerIdd", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Lecturer_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Courses", "Lecturer_Id");
            AddForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Lecturer_Id" });
            AlterColumn("dbo.Courses", "Lecturer_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Courses", "LecturerIdd");
            RenameColumn(table: "dbo.Courses", name: "Lecturer_Id", newName: "LecturerId");
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
