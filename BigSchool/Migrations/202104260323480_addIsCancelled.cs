namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsCancelled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCancelled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCancelled");
        }
    }
}
