using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class GlobalController : Controller
    {
        // GET: Global
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        public ActionResult Index()
        {
            return View();
        }
    }
}