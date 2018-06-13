namespace SprintPlaner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statusadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quests", "StatusInSprint", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quests", "StatusInSprint");
        }
    }
}
