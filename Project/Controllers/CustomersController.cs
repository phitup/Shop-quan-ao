using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class CustomersController : Controller
    {
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(Customer kh)
        {
            db.Customers.Add(kh);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string taikhoan = f["txtusername"].ToString();
            string MatKhau = f.Get("txtMatKhau").ToString();
            Customer kh = db.Customers.SingleOrDefault(x => x.username == taikhoan && x.password == MatKhau);
            
            if(kh != null)
            {
                ViewBag.ThongBao = "Chức mừng bạn đăng nhập thành công !";
                Session["username"] = kh;
                ViewBag.TaiKhoan = taikhoan;
                return View();
            }
            ViewBag.ThongBao = "Tên Tài Khoản hoặc mật khẩu không chính xác !";
            return PartialView();
        }
    }
}