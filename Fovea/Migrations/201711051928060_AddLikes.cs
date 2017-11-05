namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLikes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "Likes", c => c.Int(nullable: false));
            AddColumn("dbo.BusinessSummaryDTOes", "Likes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessSummaryDTOes", "Likes");
            DropColumn("dbo.Businesses", "Likes");
        }
    }
}
