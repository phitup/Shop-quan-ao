﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class KhachHangController : Controller
    {
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // GET: KhachHang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getKhachHang()
        {
            var v = from t in db.News
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
    }
}