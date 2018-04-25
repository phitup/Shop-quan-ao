using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.Help;
using Project.Models;

namespace Project.Areas.quantri.Controllers
{
    public class BannersController : Controller
    {
        private ShopOnlineEntities1 db = new ShopOnlineEntities1();

        // GET: quantri/Banners
        public ActionResult Index()
        {
            return View(db.Banners.ToList());
        }

        // GET: quantri/Banners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banner banner = db.Banners.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        // GET: quantri/Banners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: quantri/Banners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "id,name,img,description,hide,meta")] Banner banner , HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/upload/img/news"), filename);
                    img.SaveAs(path);
                    banner.img = filename;
                }
                else
                {
                    banner.img = "logo.png";
                }
                banner.meta = Functions.ConvertToUnSign(banner.name);
                db.Banners.Add(banner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banner);
        }

        // GET: quantri/Banners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banner banner = db.Banners.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        // POST: quantri/Banners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "id,name,img,description,hide,meta")] Banner banner ,HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            Banner temp = getById(banner.id);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/upload/img/news"), filename);
                    img.SaveAs(path);
                    temp.img = filename;
                }
                temp.name = banner.name;
                temp.description = banner.description;
                temp.meta = Functions.ConvertToUnSign(banner.meta);
                temp.hide = banner.hide;
                try
                {
                    db.Entry(banner).State = EntityState.Modified;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banner);
        }

        private Banner getById(int id)
        {
            return db.Banners.Where(x => x.id == id).FirstOrDefault();
        }

        // GET: quantri/Banners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banner banner = db.Banners.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        // POST: quantri/Banners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banner banner = db.Banners.Find(id);
            db.Banners.Remove(banner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
