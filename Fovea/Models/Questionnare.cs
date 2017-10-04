using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class Questionnare
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateSubmitted { get; set; }
        public int BusinessId { get; set; }
        public Business Business { get; set; }
    }
}