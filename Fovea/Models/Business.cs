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
        public string Country { get; set; }
        public string Province { get; set; }
        public string AddressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        public string RegistrationNumber { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //Foreign Key
        public int SellerId { get; set; }
        public int BusinessCategoryId { get; set; }
        public int BusinessSectorId { get; set; }
        //Navigation Property
        public Seller Seller { get; set; }
        public BusinessCategory BusinessCategory { get; set; }
        public BusinessSector BusinessSector { get; set; }
    }
}