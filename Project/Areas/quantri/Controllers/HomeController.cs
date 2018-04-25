using Project.Help;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.quantri.Controllers
{
    public class HomeController : Controller
    {
        private ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // GET: quantri/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user_name, string password)
        {
            string passwordMD5 = Common.EncryptMD5(password);
            var user = db.Users.SingleOrDefault(x => x.username == user_name && x.password == passwordMD5);
            if (user != null)
            {
                Session["id"] = user.id;
                Session["user_name"] = user.username;
                return RedirectToAction("Index");
            }
            ViewBag.error = "Đăng nhập thất bại hoặc bạn không có quyền vào ";
            return View();
        }
        public ActionResult Logout()
        {
            Session["id"] = null;
            Session["user_name"] = null;
            return RedirectToAction("Login");
        }
    }
}