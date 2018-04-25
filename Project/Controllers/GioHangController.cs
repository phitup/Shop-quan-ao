using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class GioHangController : Controller
    {
        ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // lấy giỏ hàng
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if(lstGioHang == null)
            {
                // nếu giỏ hàng chưa tồn tại thì tiến hành tạo
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        // Thêm Giỏ Hàng
        public ActionResult ThemGioHang (int iMaSP , string strURL)
        {
            product product = db.products.SingleOrDefault(n => n.id == iMaSP);
            if(product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //lấy session giỏ hàng
            List<GioHang> lstGioHang = LayGioHang();
            // kiểm tra sản phẩm đã tồn tại trong session chưa 
            GioHang sanpham = lstGioHang.Find(n => n.iMaSP == iMaSP);
            if(sanpham == null)
            {
                sanpham = new GioHang(iMaSP);
                lstGioHang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoLuong++;
                return Redirect(strURL);
            }

        }

        public ActionResult CapNhatGioHang (int iMaSP , FormCollection f)
        {
            product product = db.products.SingleOrDefault(x => x.id == iMaSP);
            if(product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(x => x.iMaSP == iMaSP);
            if(sanpham != null)
            {
                sanpham.iSoLuong = int.Parse( f["txtSoLuong"].ToString());
            }
            return View("GioHang");
        }
        public ActionResult XoaGioHang(int iMaSP)
        {
            product product = db.products.SingleOrDefault(x => x.id == iMaSP);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(x => x.iMaSP == iMaSP);
            if (sanpham != null)
            {
                lstGioHang.RemoveAll(x => x.iMaSP == sanpham.iMaSP);
            }
            if(lstGioHang.Count == 0)
            {
                return RedirectToAction("Index" , "Home");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult GioHang()
        {
            if(Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<GioHang> lstGioHang = LayGioHang();
            return View(lstGioHang);
        }

        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if(lstGioHang != null)
            {
                iTongSoLuong = lstGioHang.Sum(x => x.iSoLuong);
            }
            return iTongSoLuong;
        }

        private double TongTien()
        {
            double dTongTien = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if(lstGioHang != null)
            {
                dTongTien = lstGioHang.Sum(x => x.ThanhTien);
            }
            return dTongTien;
        }
        public ActionResult GioHangPartial()
        {
            if(TongSoLuong() == 0)
            {
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
    }
}