using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class FoveaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FoveaContext() : base("name=FoveaContext")
        {
            //to check the sql statements generated
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s); 
        }

        public System.Data.Entity.DbSet<Fovea.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.SubCategory> Subcategories { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Region> Regions { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Business> Businesses { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.BusinessCategory> BusinessCategories { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Seller> Sellers { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Question> Questions { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Questionnare> Questionnares { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.QuestionnareResponse> QuestionnareResponses { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Subscriber> Subscribers { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.Subscription> Subscriptions { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.BusinessSector> BusinessSectors { get; set; }

        public System.Data.Entity.DbSet<Fovea.Models.BusinessSummaryDTO> BusinessSummaryDTOes { get; set; }
    }
}
