namespace CinemaStar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "image_path", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "rating", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "rating");
            DropColumn("dbo.Movies", "image_path");
        }
    }
}
