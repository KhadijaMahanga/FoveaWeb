namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessCategories", "Img", c => c.String());
            AddColumn("dbo.BusinessSummaryDTOes", "BusinessCategoryName", c => c.String());
            AddColumn("dbo.BusinessSummaryDTOes", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessSummaryDTOes", "Description");
            DropColumn("dbo.BusinessSummaryDTOes", "BusinessCategoryName");
            DropColumn("dbo.BusinessCategories", "Img");
        }
    }
}
