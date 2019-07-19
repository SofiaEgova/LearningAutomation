namespace LearningAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LearningMaterials",
                c => new
                    {
                        LearningMaterialId = c.Guid(nullable: false),
                        File = c.Binary(),
                    })
                .PrimaryKey(t => t.LearningMaterialId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Guid(nullable: false),
                        LearningMaterialId = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TestId)
                .ForeignKey("dbo.LearningMaterials", t => t.LearningMaterialId, cascadeDelete: true)
                .Index(t => t.LearningMaterialId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Guid(nullable: false),
                        TestId = c.Guid(nullable: false),
                        Title = c.String(),
                        Answer1 = c.String(),
                        Answer2 = c.String(),
                        Answer3 = c.String(),
                        Answer4 = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ResultId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResultId)
                .ForeignKey("dbo.Users", t => t.ResultId)
                .Index(t => t.ResultId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "ResultId", "dbo.Users");
            DropForeignKey("dbo.Questions", "TestId", "dbo.Tests");
            DropForeignKey("dbo.Tests", "LearningMaterialId", "dbo.LearningMaterials");
            DropIndex("dbo.Results", new[] { "ResultId" });
            DropIndex("dbo.Questions", new[] { "TestId" });
            DropIndex("dbo.Tests", new[] { "LearningMaterialId" });
            DropTable("dbo.Users");
            DropTable("dbo.Results");
            DropTable("dbo.Questions");
            DropTable("dbo.Tests");
            DropTable("dbo.LearningMaterials");
        }
    }
}
