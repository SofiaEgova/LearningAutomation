namespace LearningAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "TestId", c => c.Guid(nullable: false));
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Results", "TestId");
            AddForeignKey("dbo.Results", "TestId", "dbo.Tests", "TestId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "TestId", "dbo.Tests");
            DropIndex("dbo.Results", new[] { "TestId" });
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.Results", "TestId");
        }
    }
}
