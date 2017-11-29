using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class BusinessSummaryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public string PriceRange { get; set; }
        public string BusinessSectorName { get; set; }
        public string BusinessCategoryName { get; set; }
        public string BusinessSubCategoryName { get; set; }
        public string BusinessCategoryImg { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }

    }
}