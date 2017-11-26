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
            var businesses = db.Businesses.Include("BusinessSector").Include("BusinessCategory").ToList();
            var businessesSummary = businesses.Select(b => new BusinessSummaryDTO
                             {
                                 Id = b.Id,
                                 Name = b.Name,
                                 Province = b.Province,
                                 City = b.City,
                                 Price = b.Price,
                                 BusinessSectorName = b.BusinessSector.Name,
                                 BusinessCategoryName = b.BusinessCategory.Name,
                                 BusinessCategoryImg = b.BusinessCategory.Img,
                                 Description = b.Description,
                                 Likes = b.Likes
                             }).ToList();
            return View(businessesSummary);
        }

        //GET: Business/id
        public ActionResult Details(int id) {
            var business = db.Businesses.Find(id);
            return View(business);
        }

        [ActionName("sell-a-business")]
        public ActionResult SellABusiness()
        {
            return View();
        }

        // GET: /Business/register-business
        [ActionName("register-business")]
        public ActionResult RegisterBusiness()
        {
            ViewBag.Categories = new SelectList(db.BusinessCategories, "Id", "Name");
            return View();
        }

        // POST: /Business/register-business
        [HttpPost]
        [ActionName("register-business")]
        public ActionResult RegisterBusiness(Business abusiness)
        {
            if (ModelState.IsValid)
            {
                db.Businesses.Add(abusiness);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(db.BusinessCategories, "Id", "Name");
            return View(abusiness);
        }

    }
}