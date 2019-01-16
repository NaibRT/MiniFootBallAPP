namespace MiniFootBall_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiniFootball : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "File", c => c.String(nullable: false));
            DropColumn("dbo.Matches", "Team_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "Team_Id", c => c.Int());
            AlterColumn("dbo.Users", "File", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Surname", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            CreateIndex("dbo.Matches", "Team_Id");
            AddForeignKey("dbo.Matches", "Team_Id", "dbo.Teams", "Id");
        }
    }
}
