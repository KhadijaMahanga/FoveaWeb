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
        public decimal Price { get; set; }
        public string BusinessSectorName { get; set; }

    }
}