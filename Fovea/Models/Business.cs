using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class Business
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string ImageUrl { get; set; }
        public string FinancialFileUrl { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        public string RegistrationNumber { get; set; }
        public int CurrencyId { get; set; }
        public decimal Price { get; set; }
        public decimal Revenue { get; set; }
        public decimal CashFlow { get; set; }
        public string Description { get; set; }
        public string PriceRange { get; set; }
        public string CashFlowRange { get; set; }
        public string RevenueRange { get; set; }
        public string Location { get; set; }
        public string PremisesDetails { get; set; }
        public string YearEstablished { get; set; }
        public string Competition { get; set; }
        public string ExpansionPotential { get; set; }
        public string SupportingAndTraining { get; set; }
        public string TradingHours { get; set; }
        public string ReasonForSelling { get; set; }
        public string Size { get; set; }
        public string Employess { get; set; }
        public string Website { get; set; }
        public int Likes { get; set; }
        //Foreign Key
        public int SellerId { get; set; }
        public int BusinessCategoryId { get; set; }
        public int BusinessSubCategory { get; set; }
        public int BusinessSectorId { get; set; }
        //Navigation Property
        public Seller Seller { get; set; }
        public BusinessCategory BusinessCategory { get; set; }
        public BusinessSector BusinessSector { get; set; }
        public SubCategory SubCategory { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }


        public BusinessListingStatus Status { get; set; }
    }
    public enum BusinessListingStatus
    {
        Approved,
        Pending,
        Rejected,
        Active,
        Inactive
    }
}