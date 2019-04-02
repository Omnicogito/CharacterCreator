using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CharCreator.Data;

namespace CharacterCreator.Controllers
{
    public class CharRacesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CharRaces
        public ActionResult Index()
        {
            var charRaces = db.CharRaces.Include(c => c.Character);
            return View(charRaces.ToList());
        }

        // GET: CharRaces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharRace charRace = db.CharRaces.Find(id);
            if (charRace == null)
            {
                return HttpNotFound();
            }
            return View(charRace);
        }

        // GET: CharRaces/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Characters, "ID", "CharName");
            return View();
        }

        // POST: CharRaces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RaceName,Size,Speed,SpecialAttributes,Languages")] CharRace charRace)
        {
            if (ModelState.IsValid)
            {
                db.CharRaces.Add(charRace);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Characters, "ID", "CharName", charRace.ID);
            return View(charRace);
        }

        // GET: CharRaces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharRace charRace = db.CharRaces.Find(id);
            if (charRace == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Characters, "ID", "CharName", charRace.ID);
            return View(charRace);
        }

        // POST: CharRaces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RaceName,Size,Speed,SpecialAttributes,Languages")] CharRace charRace)
        {
            if (ModelState.IsValid)
            {
                db.Entry(charRace).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Characters, "ID", "CharName", charRace.ID);
            return View(charRace);
        }

        // GET: CharRaces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharRace charRace = db.CharRaces.Find(id);
            if (charRace == null)
            {
                return HttpNotFound();
            }
            return View(charRace);
        }

        // POST: CharRaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CharRace charRace = db.CharRaces.Find(id);
            db.CharRaces.Remove(charRace);
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
