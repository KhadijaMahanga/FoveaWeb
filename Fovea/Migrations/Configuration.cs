namespace Fovea.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Fovea.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Fovea.Models.FoveaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Fovea.Models.FoveaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Businesses.AddOrUpdate(
                b => b.Id,
                new Business() { Id = 1, Name = "ABC Company", BusinessCategoryId = 2, SellerId = 2, BusinessSectorId = 3, RegistrationNumber = "00023985", Country = "South Africa", City = "Capetown", Likes=0, RegistrationDate = new DateTime(2015, 01, 03) },
                new Business() { Id = 2, Name = "Fashionista", BusinessCategoryId = 2, SellerId = 2, BusinessSectorId = 3, RegistrationNumber = "00023985", Country = "South Africa", City = "Capetown", Likes=1, RegistrationDate = new DateTime(2015, 01, 03) },
                new Business() { Id = 3, Name = "D Saloon", BusinessCategoryId = 2, SellerId = 2, BusinessSectorId = 3, RegistrationNumber = "00023985", Country = "South Africa", City = "Capetown", Likes=0, RegistrationDate = new DateTime(2015, 01, 03) }
                );
            context.BusinessCategories.AddOrUpdate(
                x => x.Id,
                new BusinessCategory() { Id = 1, Name = "Medium-sized" },
                new BusinessCategory() { Id = 2, Name = "Small" },
                new BusinessCategory() { Id = 3, Name = "Micro" }
                );
            context.BusinessSectors.AddOrUpdate(
                x => x.Id,
                new BusinessSector() { Id = 1, Name = "Agriculture" },
                new BusinessSector() { Id = 2, Name = "Software" },
                new BusinessSector() { Id = 3, Name = "Professional & Commercial Services" },
                new BusinessSector() { Id = 4, Name = "Construction" },
                new BusinessSector() { Id = 5, Name = "Fashion" }
                );
            context.Questions.AddOrUpdate(
                 x => x.Id,
                new Question() { Id = 1, Text = "Agriculture" },
                new Question() { Id = 2, Text = "Software" },
                new Question() { Id = 3, Text = "Professional & Commercial Services" },
                new Question() { Id = 4, Text = "Construction" }
                );
            context.Sellers.AddOrUpdate(
                 x => x.Id,
                new Seller() { Id = 1, FirstName = "Samuel", LastName = "Kassim", Email = "samuelk@yahoo.com", Address = "Capetown" },
                new Seller() { Id = 2, FirstName = "John", LastName = "Hashim", Email = "john.hashim@gmail.com", Address = "Kwazulu-natal" },
                new Seller() { Id = 3, FirstName = "Tundu", LastName = "Zuna", Email = "tindutz@live.co.uk", Address = "Durban" },
                new Seller() { Id = 4, FirstName = "Milton", LastName = "Siaga", Email = "siaga.m@gmail.com", Address = "Pretoria" }
                );
            context.Subscribers.AddOrUpdate(

                 x => x.Id,
                new Subscriber() { Id = 1, Name = "H Safiri", Email = "hsafiri@gmail.com", Status = "Active", SubscriptionId = 3, SubscriptionDate = new DateTime(2017, 01, 03) },
                new Subscriber() { Id = 2, Name = "Salim Grozdanoski", Email = "salim.g@gmail.com", Status = "Active", SubscriptionId = 1, SubscriptionDate = new DateTime(2017, 01, 03) },
                new Subscriber() { Id = 3, Name = "Z Henry", Email = "h.z.advisory@outlook.com", Status = "Inactive", SubscriptionId = 1, SubscriptionDate = new DateTime(2017, 01, 03) },
                new Subscriber() { Id = 4, Name = "Neale Evert", Email = "n.evert@yahoo.com", Status = "Unsubscribe", SubscriptionId = 2, SubscriptionDate = new DateTime(2017, 01, 03) }
                );

            context.Subscriptions.AddOrUpdate(
                 x => x.Id,
                new Subscription() { Id = 1, SubricriptionDuration = 3 },
                new Subscription() { Id = 2, SubricriptionDuration = 6 },
                new Subscription() { Id = 3, SubricriptionDuration = 12 }
                );
        }
    }
}
