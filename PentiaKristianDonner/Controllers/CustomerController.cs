using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PentiaKristianDonner.DAL;
using PentiaKristianDonner.Models;
using System.Diagnostics;
using PentiaKristianDonner.SQLHandler;

namespace PentiaKristianDonner.Controllers
{
    public class CustomerController : Controller
    {
        private PentiaKristianDonnerContext db = new PentiaKristianDonnerContext();
        Searches searches = new Searches();

        public ActionResult Index(string searchString, string submit)
        {

            var customers = from s in db.Customers select s;
            if (submit != null && searchString != null)
            {
                switch (submit)
                {
                    case "SearchByName":
                        customers = searches.SearchByName(searchString).ToList().AsQueryable();
                        break;
                    case "SearchByAddress":
                        customers = searches.SearchByAddress(searchString).ToList().AsQueryable();
                        break;
                    case "SearchByMake":
                        customers = searches.SearchByMake(searchString).ToList().AsQueryable();
                        break;
                    case "SearchByModel":
                        customers = searches.SearchByModel(searchString).ToList().AsQueryable();
                        break;
                    case "SearchBySalesPerson":
                        customers = searches.SearchBySalesPerson(searchString).ToList().AsQueryable();
                        break;



                }
            }




            return View(customers.ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,Address,Name,Surname,Age,Created")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,Address,Name,Surname,Age,Created")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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
