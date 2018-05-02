using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // GET: Product
        public ActionResult Index(string meta)
        {
            var v = from t in db.categories
                    where t.meta == meta
                    select t;
            return View(v.FirstOrDefault());

        }
        public ActionResult Detail(string meta)
        {
            var v = from t in db.products
                    where t.meta == meta
                    select t;
            return View(v.FirstOrDefault());
        }
    }
}