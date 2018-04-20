using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.Help;
using Project.Models;

namespace Project.Areas.quantri.Controllers
{
    public class productController : Controller
    {
        private ShopOnlineEntities1 db = new ShopOnlineEntities1();
        // GET: quantri/product
      
        public ActionResult Index(long? id = null)
        {
            getCategory(id);
            return View();
            //return View(db.products.ToList());
        }

        public void getCategory(long? selectedId = null)
        {
            ViewBag.category = new SelectList(db.categories.Where(x => x.hide == true).OrderBy(x => x.order), "id", "name", selectedId);
        }

        public ActionResult getProduct(long? id)
        {
            if(id == null)
            {
                var v = db.products.OrderBy(x => x.order).ToList();
                return PartialView(v);
            }
            var m = db.products.Where(x => x.categoryid == id).OrderBy(x => x.order).ToList();
            return PartialView(m);
        }

        // GET: quantri/product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: quantri/product/Create
        public ActionResult Create()
        {
            getCategory();
            return View();
        }

        // POST: quantri/product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "id,name,price,img,description,meta,size,color,hdie,order,datebegin,categoryid")] product product,HttpPostedFileBase img)
        {
            try
            {
                var path = "";
                var filename = "";
                if (ModelState.IsValid)
                {
                    if (img != null)
                    {
                        filename = img.FileName;
                        path = Path.Combine(Server.MapPath("~/Content/upload/img/product"), filename);
                        img.SaveAs(path);
                        product.img = filename;
                    }
                    else
                    {
                        product.img = "logo.png";
                    }
                    product.datebegin = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    product.meta = Functions.ConvertToUnSign(product.meta);
                    product.order = getMaxOrder(product.categoryid);
                    db.products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index", "product", new { id = product.categoryid });
                }
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(product);
        }

        private int getMaxOrder(int? categoryid)
        {
            return db.products.Where(x => x.categoryid == categoryid).Count();
        }



        // GET: quantri/product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            getCategory(product.categoryid);
            return View(product);
        }

        // POST: quantri/product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "id,name,price,img,description,meta,size,color,hdie,order,datebegin,categoryid")] product product, HttpPostedFileBase img)
        {
            try
            {
                var path = "";
                var filename = "";
                product temp = getById(product.id);
                if (ModelState.IsValid)
                {
                    if (img != null)
                    {
                        filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss-") + img.FileName;
                        path = Path.Combine(Server.MapPath("~/Content/upload/img/product"), filename);
                        img.SaveAs(path);
                        temp.img = filename;
                    }
                    temp.name = product.name;
                    temp.price = product.price;
                    temp.description = product.description;
                    temp.meta = Functions.ConvertToUnSign(product.meta);
                    temp.color = product.color;
                    temp.size = product.size;
                    temp.hdie = product.hdie;
                    temp.order = product.order;

                    db.Entry(temp).State = EntityState.Modified;

                    db.SaveChanges();
                    return RedirectToAction("Index", "product", new { id = product.categoryid });
                }
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
            return View(product);
        }

        private product getById(int id)
        {
            return db.products.Where(x => x.id == id).FirstOrDefault();
        }

        // GET: quantri/product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: quantri/product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.products.Find(id);
            db.products.Remove(product);
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
