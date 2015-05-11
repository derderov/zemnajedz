using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZeMnaJedz.Models;

namespace ZeMnaJedz.Controllers
{
    public class OfferController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Offer
        public ActionResult Index()
        {
            var offers = db.Offers.Include(o => o.Car);
            return View(offers.ToList());
        }

        // GET: Offer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferModel offerModel = db.Offers.Find(id);
            if (offerModel == null)
            {
                return HttpNotFound();
            }
            return View(offerModel);
        }

        // GET: Offer/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Brand");
            return View();
        }

        // POST: Offer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfferID,IdentityDetailsID,CarID,Street,City,Destination,When,NumberOfSeats,Login,Price,StreetNumber,AdditionalInfo")] OfferModel offerModel)
        {
            var car = db.Cars.Find(offerModel.CarID);

            if (ModelState.IsValid && car != null)
            {
                offerModel.Car = car;
                offerModel.Passengers = new List<PassengerModel>();
                offerModel.IdentityDetailsID = car.IdentityDetailsID;

                db.Offers.Add(offerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Brand", offerModel.CarID);
            return View(offerModel);
        }

        // GET: Offer/Edit/5

        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferModel offerModel = db.Offers.Find(id);
            if (offerModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Brand", offerModel.CarID);
            return View(offerModel);
        }

        // POST: Offer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OfferID,IdentityDetailsID,CarID,Street,City,Destination,When,NumberOfSeats,Login,Price,StreetNumber,AdditionalInfo")] OfferModel offerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "Brand", offerModel.CarID);
            return View(offerModel);
        }

        // GET: Offer/Delete/5

        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferModel offerModel = db.Offers.Find(id);
            if (offerModel == null)
            {
                return HttpNotFound();
            }
            return View(offerModel);
        }

        // POST: Offer/Delete/5

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfferModel offerModel = db.Offers.Find(id);
            db.Offers.Remove(offerModel);
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
