using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Fovea.Models;

namespace Fovea.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FoveaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FoveaContext context)
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

            //  context..AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

            context.BusinessCategories.AddOrUpdate(
                x => x.Id,
                new BusinessCategory() { Id = 1, Name = "Automotive & Boats", Img = "Content/img/Category/automotive-boats.gif" },
                new BusinessCategory() { Id = 2, Name = "Commercial Real Estate", Img = "Content/img/Category/real-estate.gif" },
                new BusinessCategory() { Id = 3, Name = "Food & Beverage", Img = "Content/img/Category/food-beverage.gif" },
                new BusinessCategory() { Id = 4, Name = "Manufacturing", Img = "Content/img/Category/manufacturing" },
                new BusinessCategory() { Id = 5, Name = "Recreation", Img = "Content/img/Category/recreation.gif" },
                new BusinessCategory() { Id = 6, Name = "Retail", Img = "Content/img/Category/retail.gif" },
                new BusinessCategory() { Id = 7, Name = "Miscellaneous", Img = "Content/img/Category/miscellaneous.gif" },
                new BusinessCategory() { Id = 8, Name = "Services", Img = "Content/img/Category/services.gif" },
                new BusinessCategory() { Id = 9, Name = "Technology & Media", Img = "Content/img/Category/technology-media.gif" },
                new BusinessCategory() { Id = 10, Name = "Wholesale & Distribution", Img = "Content/img/Category/wholesale-distribution.gif" },
                new BusinessCategory() { Id = 11, Name = "Engineering", Img = "Content/img/Category/engineering.gif" },
                new BusinessCategory() { Id = 12, Name = "Leisure", Img = "Content/img/Category/leisure.gif" },
                new BusinessCategory() { Id = 13, Name = "Agriculture", Img = "Content/img/Category/agriculture.gif" }
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
            context.Currencies.AddOrUpdate(
                 x => x.Id,
                new Currency() { Id = 1, Name = "ZAR" },
                new Currency() { Id = 2, Name = "USD" }
                );

            context.Countries.AddOrUpdate(
                  p => p.Id,
                  new Country { Id = 1, Name = "Kenya" },
                  new Country { Id = 2, Name = "South Africa" },
                  new Country { Id = 3, Name = "Tanzania" },
                  new Country { Id = 4, Name = "Uganda" },
                  new Country { Id = 5, Name = "Zimbabwe" },
                  new Country { Id = 6, Name = "Other" }
                );

            context.Regions.AddOrUpdate(
                p => p.Id,
                new Region { Id = 1, Name = "Western Cape", CountryId = 2 },
                new Region { Id = 2, Name = "Eastern Cape", CountryId = 2 },
                new Region { Id = 3, Name = "Free State", CountryId = 2 },
                new Region { Id = 4, Name = "Northern Cape", CountryId = 2 },
                new Region { Id = 5, Name = "Limpopo", CountryId = 2 },
                new Region { Id = 6, Name = "Mpumalanga", CountryId = 2 },
                new Region { Id = 7, Name = "Northern Cape", CountryId = 2 },
                new Region { Id = 8, Name = "KwaZulu-Natal", CountryId = 2 },
                new Region { Id = 9, Name = "Guateng", CountryId = 2 },
                new Region { Id = 10, Name = "Arusha", CountryId = 3 },
                new Region { Id = 11, Name = "Dar-es-salaam", CountryId = 3 },
                new Region { Id = 12, Name = "Dodoma", CountryId = 3 },
                new Region { Id = 13, Name = "Mwanza", CountryId = 3 },
                new Region { Id = 14, Name = "Zanzibar", CountryId = 3 },
                new Region { Id = 15, Name = "Nairobi", CountryId = 1 },
                new Region { Id = 16, Name = "Mombasa", CountryId = 1 },
                new Region { Id = 17, Name = "Kampala", CountryId = 4 },
                new Region { Id = 18, Name = "Harare", CountryId = 5 },
                new Region { Id = 19, Name = "Other", CountryId = 6 }
                );

            context.Cities.AddOrUpdate(
                p => p.Id,
                new City { Id = 1, Name = "Capetown", RegionId = 1 },
                new City { Id = 2, Name = "Johannesburg", RegionId = 9 },
                new City { Id = 3, Name = "Durban", RegionId = 8 },
                new City { Id = 4, Name = "Pretoria", RegionId = 9 },
                new City { Id = 5, Name = "Grahamston", RegionId = 2 },
                new City { Id = 6, Name = "Port Elizabeth", RegionId = 2 },
                new City { Id = 7, Name = "East London", RegionId = 2 },
                new City { Id = 8, Name = "Richards Bay", RegionId = 8 },
                new City { Id = 9, Name = "Soweto", RegionId = 9 },
                new City { Id = 10, Name = "Arusha", RegionId = 10 },
                new City { Id = 11, Name = "Dar-es-salaam", RegionId = 11 },
                new City { Id = 12, Name = "Dodoma", RegionId = 12 },
                new City { Id = 13, Name = "Mwanza", RegionId = 13 },
                new City { Id = 14, Name = "Zanzibar", RegionId = 14 },
                new City { Id = 15, Name = "Nairobi", RegionId = 15 },
                new City { Id = 16, Name = "Mombasa", RegionId = 16 },
                new City { Id = 17, Name = "Kampala", RegionId = 17 },
                new City { Id = 18, Name = "Harare", RegionId = 18 },
                new City { Id = 19, Name = "Other", RegionId = 19 }
                );

            context.Subcategories.AddOrUpdate(
                p => p.Id,
                new SubCategory { Id = 1, CategoryId = 13, Name = "Agricultural Supplies" },
                new SubCategory { Id = 2, CategoryId = 13, Name = "Ranches" },
                new SubCategory { Id = 3, CategoryId = 13, Name = "Farm" },
                new SubCategory { Id = 4, CategoryId = 13, Name = "Misc. Agriculture" },
                new SubCategory { Id = 5, CategoryId = 11, Name = "Consultant" },
                new SubCategory { Id = 6, CategoryId = 11, Name = "Electrical Services" },
                new SubCategory { Id = 7, CategoryId = 11, Name = "Utilities" },
                new SubCategory { Id = 8, CategoryId = 11, Name = "Mechanical Services" },
                new SubCategory { Id = 9, CategoryId = 11, Name = "Other" },
                new SubCategory { Id = 10, CategoryId = 3, Name = "Catering" },
                new SubCategory { Id = 11, CategoryId = 3, Name = "Cafes" },
                new SubCategory { Id = 12, CategoryId = 3, Name = "Restaurant" },
                new SubCategory { Id = 13, CategoryId = 3, Name = "Retailers" },
                new SubCategory { Id = 14, CategoryId = 3, Name = "Others" },
                new SubCategory { Id = 15, CategoryId = 12, Name = "Hotels & Spa" },
                new SubCategory { Id = 16, CategoryId = 12, Name = "Recreation" },
                new SubCategory { Id = 17, CategoryId = 12, Name = "Entertainment & Fun" },
                new SubCategory { Id = 18, CategoryId = 12, Name = "Others" }
                );
        }
    }
}
