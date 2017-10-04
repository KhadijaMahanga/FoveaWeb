namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Province = c.String(),
                        AddressLine1 = c.String(),
                        AdressLine2 = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        RegistrationDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        RegistrationNumber = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        SellerId = c.Int(nullable: false),
                        BusinessCategoryId = c.Int(nullable: false),
                        BusinessSectorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessCategories", t => t.BusinessCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.BusinessSectors", t => t.BusinessSectorId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.SellerId)
                .Index(t => t.BusinessCategoryId)
                .Index(t => t.BusinessSectorId);
            
            CreateTable(
                "dbo.BusinessSectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerID = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuestionnareResponses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Response = c.String(),
                        QuestionnareId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Questionnares", t => t.QuestionnareId, cascadeDelete: true)
                .Index(t => t.QuestionnareId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questionnares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateSubmitted = c.DateTime(precision: 7, storeType: "datetime2"),
                        BusinessId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Businesses", t => t.BusinessId, cascadeDelete: true)
                .Index(t => t.BusinessId);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        SubscriptionDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Status = c.String(),
                        SubscriptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscriptions", t => t.SubscriptionId, cascadeDelete: true)
                .Index(t => t.SubscriptionId);
            
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubricriptionDuration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscribers", "SubscriptionId", "dbo.Subscriptions");
            DropForeignKey("dbo.QuestionnareResponses", "QuestionnareId", "dbo.Questionnares");
            DropForeignKey("dbo.Questionnares", "BusinessId", "dbo.Businesses");
            DropForeignKey("dbo.QuestionnareResponses", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Businesses", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Businesses", "BusinessSectorId", "dbo.BusinessSectors");
            DropForeignKey("dbo.Businesses", "BusinessCategoryId", "dbo.BusinessCategories");
            DropIndex("dbo.Subscribers", new[] { "SubscriptionId" });
            DropIndex("dbo.Questionnares", new[] { "BusinessId" });
            DropIndex("dbo.QuestionnareResponses", new[] { "QuestionId" });
            DropIndex("dbo.QuestionnareResponses", new[] { "QuestionnareId" });
            DropIndex("dbo.Businesses", new[] { "BusinessSectorId" });
            DropIndex("dbo.Businesses", new[] { "BusinessCategoryId" });
            DropIndex("dbo.Businesses", new[] { "SellerId" });
            DropTable("dbo.Subscriptions");
            DropTable("dbo.Subscribers");
            DropTable("dbo.Questionnares");
            DropTable("dbo.Questions");
            DropTable("dbo.QuestionnareResponses");
            DropTable("dbo.Sellers");
            DropTable("dbo.BusinessSectors");
            DropTable("dbo.Businesses");
            DropTable("dbo.BusinessCategories");
        }
    }
}
