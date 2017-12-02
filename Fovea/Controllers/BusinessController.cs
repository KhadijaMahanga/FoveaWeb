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
                                 Province = b.Region.Name,
                                 City = b.City.Name,
                                 Currency = b.Currency.Name,
                                 Price = b.Price,
                                 PriceRange = b.PriceRange,
                                 BusinessSubCategoryName = b.SubCategory.Name,
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
            ViewBag.Countries = new SelectList(db.Countries, "Id", "Name");
            return View();
        }

        public JsonResult GetProvinces(int country) {
            var provinces = db.Regions.Where(c => c.CountryId == country);
            return Json(provinces, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCities(int province)
        {
            var cities = db.Cities.Where(c => c.RegionId == province);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSubCategories(int category)
        {
            var subCategories = db.Subcategories.Where(c => c.CategoryId == category);
            return Json(subCategories, JsonRequestBehavior.AllowGet);
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