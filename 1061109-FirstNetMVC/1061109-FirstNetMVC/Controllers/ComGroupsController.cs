using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _1061109_FirstNetMVC.Models;

namespace _1061109_FirstNetMVC.Controllers
{
    public class ComGroupsController : Controller
    {
        private ComGropModel db = new ComGropModel();

        // GET: ComGroups
        public ActionResult Index()
        {
            return View(db.ComGroups.ToList());
        }

        //-------------------------------
        public ActionResult AddView()
        {
            ViewData["Test"] = "路過Controller";
            return PartialView();
        }

        //--------------------------------



        // GET: ComGroups/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComGroup comGroup = db.ComGroups.Find(id);
            if (comGroup == null)
            {
                return HttpNotFound();
            }
            return View(comGroup);
        }

        // GET: ComGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComGroups/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GroupID,GroupName,GroupNameEn,Explain,Memo,AppxPath")] ComGroup comGroup)
        {
            if (ModelState.IsValid)
            {
                db.ComGroups.Add(comGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comGroup);
        }

        // GET: ComGroups/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComGroup comGroup = db.ComGroups.Find(id);
            if (comGroup == null)
            {
                return HttpNotFound();
            }
            return View(comGroup);
        }

        // POST: ComGroups/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GroupID,GroupName,GroupNameEn,Explain,Memo,AppxPath")] ComGroup comGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comGroup);
        }

        // GET: ComGroups/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComGroup comGroup = db.ComGroups.Find(id);
            if (comGroup == null)
            {
                return HttpNotFound();
            }
            return View(comGroup);
        }

        // POST: ComGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ComGroup comGroup = db.ComGroups.Find(id);
            db.ComGroups.Remove(comGroup);
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
