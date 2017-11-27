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
    public class ComSuppliersController : Controller
    {
        private CBsql_ZZEntitiesComSupplier db = new CBsql_ZZEntitiesComSupplier();

        // GET: ComSuppliers
        public ActionResult Index()
        {
            return View(db.ComSupplier.ToList());
        }

        // GET: ComSuppliers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComSupplier comSupplier = db.ComSupplier.Find(id);
            if (comSupplier == null)
            {
                return HttpNotFound();
            }
            return View(comSupplier);
        }

        // GET: ComSuppliers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComSuppliers/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SuppID,SuppName,SuppNameS,SuppClassID,Trade,InvoName,RegionID,ZipCode,Address,ZipCode1,Address1,ZipCode2,Address2,ZipCode3,Address3,TaxNo,ChiefName,CapTAL,LinkMan,LinkTitle,FaxNo,TelNo,TelNo1,TelNo2,Mobile1,Mobile2,EmplID,Email,WebSite,CreateDate,StopDate,DeliID,InvoMode,SuppID_I,TaxWay,InvoType,CurrencyID,IsTax,ActNo,BankID,PurDate,PurRDate,Sub_AP,Sub_NP,Sub_ADVSupp,SuppID_R,CustID_R,APMode,APDay,NPMode,NPDay,APLimit,CheckLimit,NotCashCheck,CreditSum,BeginAP,BeginADV,APSum,AdvSum,UnChkAP,UnChkADV,SuppNameEn,SuppNameSEn,Conditions,LinkManEn,LinkTitalEn,Payment,DeliWay,Sub_CommiR,Sub_Commi,MarkID,SuppGrade,Explain,Memo,UdefT1,UdefT2,UdefT3,UdefD1,UdefD2,UdefN1,UdefN2,RecDay,Pointude,Pointude1,Pointude2,Pointude3,AppxPath")] ComSupplier comSupplier)
        {
            if (ModelState.IsValid)
            {
                db.ComSupplier.Add(comSupplier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comSupplier);
        }

        // GET: ComSuppliers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComSupplier comSupplier = db.ComSupplier.Find(id);
            if (comSupplier == null)
            {
                return HttpNotFound();
            }
            return View(comSupplier);
        }

        // POST: ComSuppliers/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SuppID,SuppName,SuppNameS,SuppClassID,Trade,InvoName,RegionID,ZipCode,Address,ZipCode1,Address1,ZipCode2,Address2,ZipCode3,Address3,TaxNo,ChiefName,CapTAL,LinkMan,LinkTitle,FaxNo,TelNo,TelNo1,TelNo2,Mobile1,Mobile2,EmplID,Email,WebSite,CreateDate,StopDate,DeliID,InvoMode,SuppID_I,TaxWay,InvoType,CurrencyID,IsTax,ActNo,BankID,PurDate,PurRDate,Sub_AP,Sub_NP,Sub_ADVSupp,SuppID_R,CustID_R,APMode,APDay,NPMode,NPDay,APLimit,CheckLimit,NotCashCheck,CreditSum,BeginAP,BeginADV,APSum,AdvSum,UnChkAP,UnChkADV,SuppNameEn,SuppNameSEn,Conditions,LinkManEn,LinkTitalEn,Payment,DeliWay,Sub_CommiR,Sub_Commi,MarkID,SuppGrade,Explain,Memo,UdefT1,UdefT2,UdefT3,UdefD1,UdefD2,UdefN1,UdefN2,RecDay,Pointude,Pointude1,Pointude2,Pointude3,AppxPath")] ComSupplier comSupplier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comSupplier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comSupplier);
        }

        // GET: ComSuppliers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComSupplier comSupplier = db.ComSupplier.Find(id);
            if (comSupplier == null)
            {
                return HttpNotFound();
            }
            return View(comSupplier);
        }

        // POST: ComSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ComSupplier comSupplier = db.ComSupplier.Find(id);
            db.ComSupplier.Remove(comSupplier);
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
