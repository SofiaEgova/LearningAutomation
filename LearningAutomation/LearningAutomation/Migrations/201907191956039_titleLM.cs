namespace LearningAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class titleLM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LearningMaterials", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LearningMaterials", "Title");
        }
    }
}
