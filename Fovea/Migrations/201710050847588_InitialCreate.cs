namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessSummaryDTOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BusinessSectorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusinessSummaryDTOes");
        }
    }
}
