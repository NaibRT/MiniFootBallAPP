namespace MiniFootBall_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiniFootball : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameTime = c.DateTime(nullable: false),
                        AwayTeamId = c.Int(nullable: false),
                        AwayTeam_Score = c.Int(nullable: false),
                        GuestTeam_Score = c.Int(nullable: false),
                        GuestTeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.AwayTeamId, cascadeDelete: false)
                .ForeignKey("dbo.Teams", t => t.GuestTeamId, cascadeDelete: false)
                .Index(t => t.AwayTeamId)
                .Index(t => t.GuestTeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Scorr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        File = c.String(nullable: false),
                        Status = c.Byte(nullable: false),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "GuestTeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "AwayTeamId", "dbo.Teams");
            DropForeignKey("dbo.Users", "TeamId", "dbo.Teams");
            DropIndex("dbo.Users", new[] { "TeamId" });
            DropIndex("dbo.Matches", new[] { "GuestTeamId" });
            DropIndex("dbo.Matches", new[] { "AwayTeamId" });
            DropTable("dbo.Users");
            DropTable("dbo.Teams");
            DropTable("dbo.Matches");
        }
    }
}
