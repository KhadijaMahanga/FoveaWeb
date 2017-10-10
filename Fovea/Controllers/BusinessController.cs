using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fovea.Models;

namespace Fovea.Controllers
{
    public class BusinessController : Controller
    {
        //initialize database instance
        private FoveaContext db = new FoveaContext();

        // GET: Business
        public ActionResult Index()
        {
            var businesses = db.Businesses.Include("BusinessSector").ToList();
            var businessesSummary = businesses.Select(b => new BusinessSummaryDTO
                             {
                                 Id = b.Id,
                                 Name = b.Name,
                                 Province = b.Province,
                                 City = b.City,
                                 Price = b.Price,
                                 BusinessSectorName = b.BusinessSector.Name
                             }).ToList();
            return View(businessesSummary);
        }

        //GET: Business/id
        public ActionResult GetBusiness(int id) {
            var business = db.Businesses.Find(id);
            return View(business);
        }

    }
}