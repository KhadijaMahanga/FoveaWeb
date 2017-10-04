using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class Seller
    {
        public int Id { get; set; }
        // user ID from AspNetUser table
        public string OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }
        public SellerStatus Status { get; set; }
    }
    public enum SellerStatus
    {
        Approved,
        Pending,
        Rejected
    }
}