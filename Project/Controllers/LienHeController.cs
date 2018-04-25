using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.ClassJs;
using Project.Models;

namespace Project.Controllers
{
    public class LienHeController : Controller
    {
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // GET: LienHe
        public ActionResult Index()
        {
            var model = new ContactDao().GetActiveContact();
            return View(model);
        }
        [HttpPost]
        public JsonResult Send(string name , string email , string content)
        {
            var feedback = new Feedback();
            feedback.name = name;
            feedback.email = email;
            feedback.C_content = content;

            var id = new ContactDao().InsertFeedBack(feedback);
            if (id > 0)
                return Json(new
                {
                    status = true
                });
            else
                return Json(new
                {
                    status = false
                });
        }

        public ActionResult getLienHe()
        {
            var v = from t in db.News
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}