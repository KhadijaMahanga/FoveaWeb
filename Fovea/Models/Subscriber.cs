using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SubscriptionDate { get; set; }

        public string Status { get; set; }
        //Foreign Key
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }

    }
}