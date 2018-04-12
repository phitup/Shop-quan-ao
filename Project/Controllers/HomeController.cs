using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        public ActionResult Index()
        {
            /*string Chuoi = "";
            var product = (from p in db.products orderby p.id descending select p).Take(13).ToList();
            Chuoi += "<div class=\"top_grid2\">";
            for (int i=0; i<product.Count; i++)
            {
                if(i % 3 == 0)
                {
                    Chuoi += "<div class=\"top_grid2\">";
                }
                Chuoi += "<div class=\"col-md-4 top_grid1-box1\">";
                Chuoi += "<a href=\"http://localhost:62394/Home/Single/ " + product[i].id + "\">";
                Chuoi += "<div class=\"grid_1\">";
                Chuoi += "<div class=\"b-link-stroke b-animate-go thickbox\">";
                Chuoi += "<img src=\"images/" + product[i].img + "\" class=\"img-responsive\" alt=\"Nghệ Thuật\" />";
                Chuoi += "</div>";
                Chuoi += "<div class=\"grid_2\">";
                Chuoi += "<p>" + product[i].name + "</p>";
                Chuoi += "<ul class=\"grid_2-bottom\">";
                Chuoi += "<li class=\"grid_2-left\"><p> "+ product[i].price +"<small> VND</small></p></li>";
                Chuoi += "<li class=\"grid_2-right\"><div class=\"btn btn-primary btn-normal btn-inline\" target=\"_self\" title=\"BUY\">BUY</div></li>";
                Chuoi += "<div class=\"clearfix\">";
                Chuoi += "</div>";
                Chuoi += "</ul>";
                Chuoi += "</div>";
                Chuoi += "</div>";
                Chuoi += "</a>";
                Chuoi += "</div>";
  
                if ((i + 1) % 3 == 0)
                {
                    Chuoi += "<div class=\"clearfix\"> </div>";
                    Chuoi += "</div>";
                }          
               
            }            
            ViewBag.View = Chuoi;*/
            List<product> pList = db.products.ToList(); 
            return View(pList);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Careers()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }

        public ActionResult Category(long categoryID)
        {
            //var category = _db.Menus.Where(x => x.Id == 3).FirstOrDefault();
            List<product> cList = db.products.Where(x => x.categoryid == categoryID).ToList();
            return View(cList);
        }

        public ActionResult ProductDetail(long productID)
        {
            //var category = _db.Menus.Where(x => x.Id == 3).FirstOrDefault();
            product product = db.products.Where(x => x.id == productID).SingleOrDefault();
            return View(product);
        }

        public ActionResult Menu()
        {
            List<category> cList = db.categories.ToList();
            return PartialView("Menu", cList);
        }

        public ActionResult Wishlist()
        {
            return View();
        }
    }
}