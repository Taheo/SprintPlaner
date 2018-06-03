namespace SprintPlaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quests",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        StoryValue = c.Int(nullable: false),
                        Sprint_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sprints", t => t.Sprint_Id)
                .Index(t => t.Sprint_Id);
            
            CreateTable(
                "dbo.Sprints",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ProjectRole = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quests", "Sprint_Id", "dbo.Sprints");
            DropIndex("dbo.Quests", new[] { "Sprint_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Sprints");
            DropTable("dbo.Quests");
        }
    }
}
