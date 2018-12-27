using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRM.Models;

namespace HRM.Controllers
{
    public class AppRegController : Controller
    {
        private AppReg db = new AppReg();

        int test = 20;

        // GET: AppReg
        public ActionResult Index()
        {
            return View(db.jb_applicant_register.ToList());
        }

        // GET: AppReg/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jb_applicant_register jb_applicant_register = db.jb_applicant_register.Find(id);
            if (jb_applicant_register == null)
            {
                return HttpNotFound();
            }
            return View(jb_applicant_register);
        }

        // GET: AppReg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppReg/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "regId,jb_app_no,jb_email,jb_applicant_name,jb_app_date,jb_email_ack,jb_resp_ack,jb_app_pwd,jb_email_desc,jb_tel_no")] jb_applicant_register jb_applicant_register)
        {
            if (ModelState.IsValid)
            {
                db.jb_applicant_register.Add(jb_applicant_register);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jb_applicant_register);
        }

        // GET: AppReg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jb_applicant_register jb_applicant_register = db.jb_applicant_register.Find(id);
            if (jb_applicant_register == null)
            {
                return HttpNotFound();
            }
            return View(jb_applicant_register);
        }

        // POST: AppReg/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "regId,jb_app_no,jb_email,jb_applicant_name,jb_app_date,jb_email_ack,jb_resp_ack,jb_app_pwd,jb_email_desc,jb_tel_no")] jb_applicant_register jb_applicant_register)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jb_applicant_register).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jb_applicant_register);
        }

        // GET: AppReg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            jb_applicant_register jb_applicant_register = db.jb_applicant_register.Find(id);
            if (jb_applicant_register == null)
            {
                return HttpNotFound();
            }
            return View(jb_applicant_register);
        }

        // POST: AppReg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            jb_applicant_register jb_applicant_register = db.jb_applicant_register.Find(id);
            db.jb_applicant_register.Remove(jb_applicant_register);
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
