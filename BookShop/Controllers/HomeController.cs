using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var product = new ProductDAO();
            ViewBag.NewProducts = product.ListNewProduct(3);
            ViewBag.ListFeatureProducts = product.ListFeatureProduct(3);
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult Header()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}