namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCategory1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessSummaryDTOes", "BusinessCategoryImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessSummaryDTOes", "BusinessCategoryImg");
        }
    }
}
