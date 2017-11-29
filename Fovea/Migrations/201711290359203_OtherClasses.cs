namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtherClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        BusinessCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessCategories", t => t.BusinessCategory_Id)
                .Index(t => t.BusinessCategory_Id);
            
            AddColumn("dbo.Businesses", "CountryId", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "RegionId", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "Address", c => c.String());
            AddColumn("dbo.Businesses", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "ImageUrl", c => c.String());
            AddColumn("dbo.Businesses", "FinancialFileUrl", c => c.String());
            AddColumn("dbo.Businesses", "Revenue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Businesses", "CashFlow", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Businesses", "PriceRange", c => c.String());
            AddColumn("dbo.Businesses", "CashFlowRange", c => c.String());
            AddColumn("dbo.Businesses", "RevenueRange", c => c.String());
            AddColumn("dbo.Businesses", "Location", c => c.String());
            AddColumn("dbo.Businesses", "PremisesDetails", c => c.String());
            AddColumn("dbo.Businesses", "YearEstablished", c => c.String());
            AddColumn("dbo.Businesses", "Competition", c => c.String());
            AddColumn("dbo.Businesses", "ExpansionPotential", c => c.String());
            AddColumn("dbo.Businesses", "SupportingAndTraining", c => c.String());
            AddColumn("dbo.Businesses", "TradingHours", c => c.String());
            AddColumn("dbo.Businesses", "ReasonForSelling", c => c.String());
            AddColumn("dbo.Businesses", "Size", c => c.String());
            AddColumn("dbo.Businesses", "Employess", c => c.String());
            AddColumn("dbo.Businesses", "Website", c => c.String());
            AddColumn("dbo.Businesses", "BusinessSubCategory", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "SubCategory_Id", c => c.Int());
            AddColumn("dbo.BusinessSummaryDTOes", "Country", c => c.String());
            AddColumn("dbo.BusinessSummaryDTOes", "PriceRange", c => c.String());
            AddColumn("dbo.BusinessSummaryDTOes", "BusinessSubCategoryName", c => c.String());
            CreateIndex("dbo.Businesses", "RegionId");
            CreateIndex("dbo.Businesses", "CityId");
            CreateIndex("dbo.Businesses", "SubCategory_Id");
            AddForeignKey("dbo.Businesses", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Businesses", "RegionId", "dbo.Regions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Businesses", "SubCategory_Id", "dbo.SubCategories", "Id");
            DropColumn("dbo.Businesses", "Country");
            DropColumn("dbo.Businesses", "Province");
            DropColumn("dbo.Businesses", "AddressLine1");
            DropColumn("dbo.Businesses", "AdressLine2");
            DropColumn("dbo.Businesses", "PostalCode");
            DropColumn("dbo.Businesses", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "City", c => c.String());
            AddColumn("dbo.Businesses", "PostalCode", c => c.String());
            AddColumn("dbo.Businesses", "AdressLine2", c => c.String());
            AddColumn("dbo.Businesses", "AddressLine1", c => c.String());
            AddColumn("dbo.Businesses", "Province", c => c.String());
            AddColumn("dbo.Businesses", "Country", c => c.String());
            DropForeignKey("dbo.Businesses", "SubCategory_Id", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "BusinessCategory_Id", "dbo.BusinessCategories");
            DropForeignKey("dbo.Businesses", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Businesses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "RegionId", "dbo.Regions");
            DropIndex("dbo.SubCategories", new[] { "BusinessCategory_Id" });
            DropIndex("dbo.Cities", new[] { "RegionId" });
            DropIndex("dbo.Businesses", new[] { "SubCategory_Id" });
            DropIndex("dbo.Businesses", new[] { "CityId" });
            DropIndex("dbo.Businesses", new[] { "RegionId" });
            DropColumn("dbo.BusinessSummaryDTOes", "BusinessSubCategoryName");
            DropColumn("dbo.BusinessSummaryDTOes", "PriceRange");
            DropColumn("dbo.BusinessSummaryDTOes", "Country");
            DropColumn("dbo.Businesses", "SubCategory_Id");
            DropColumn("dbo.Businesses", "Status");
            DropColumn("dbo.Businesses", "BusinessSubCategory");
            DropColumn("dbo.Businesses", "Website");
            DropColumn("dbo.Businesses", "Employess");
            DropColumn("dbo.Businesses", "Size");
            DropColumn("dbo.Businesses", "ReasonForSelling");
            DropColumn("dbo.Businesses", "TradingHours");
            DropColumn("dbo.Businesses", "SupportingAndTraining");
            DropColumn("dbo.Businesses", "ExpansionPotential");
            DropColumn("dbo.Businesses", "Competition");
            DropColumn("dbo.Businesses", "YearEstablished");
            DropColumn("dbo.Businesses", "PremisesDetails");
            DropColumn("dbo.Businesses", "Location");
            DropColumn("dbo.Businesses", "RevenueRange");
            DropColumn("dbo.Businesses", "CashFlowRange");
            DropColumn("dbo.Businesses", "PriceRange");
            DropColumn("dbo.Businesses", "CashFlow");
            DropColumn("dbo.Businesses", "Revenue");
            DropColumn("dbo.Businesses", "FinancialFileUrl");
            DropColumn("dbo.Businesses", "ImageUrl");
            DropColumn("dbo.Businesses", "CityId");
            DropColumn("dbo.Businesses", "Address");
            DropColumn("dbo.Businesses", "RegionId");
            DropColumn("dbo.Businesses", "CountryId");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Regions");
            DropTable("dbo.Cities");
        }
    }
}
