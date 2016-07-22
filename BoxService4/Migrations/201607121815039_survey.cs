namespace BoxService4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class survey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        QuestionOne = c.Boolean(nullable: false),
                        QuestionTwo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surveys");
        }
    }
}
