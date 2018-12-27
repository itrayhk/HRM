using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRM.Models;

namespace HRM.Views
{
    public class jb_applicant_registerController : Controller
    {
        private AppReg db = new AppReg();

        // GET: jb_applicant_register
        public ActionResult Index()
        {
            return View(db.jb_applicant_register.ToList());
        }

        // GET: jb_applicant_register/Details/5
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

        // GET: jb_applicant_register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jb_applicant_register/Create
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

        // GET: jb_applicant_register/Edit/5
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

        // POST: jb_applicant_register/Edit/5
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

        // GET: jb_applicant_register/Delete/5
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

        // POST: jb_applicant_register/Delete/5
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
