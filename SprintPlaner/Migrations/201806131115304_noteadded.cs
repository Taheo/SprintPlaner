namespace SprintPlaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noteadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quests", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quests", "Note");
        }
    }
}
