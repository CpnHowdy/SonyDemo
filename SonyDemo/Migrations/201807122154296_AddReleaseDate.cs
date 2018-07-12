namespace SonyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "ReleaseDate");
        }
    }
}
