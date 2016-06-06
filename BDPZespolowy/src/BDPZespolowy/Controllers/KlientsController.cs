using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class KlientsController : Controller
    {
        private ApplicationDbContext _context;

        public KlientsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Klients
        public IActionResult Index()
        {
            return View(_context.Klient.ToList());
        }

        // GET: Klients/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Klient klient = _context.Klient.Single(m => m.ID == id);
            if (klient == null)
            {
                return HttpNotFound();
            }

            return View(klient);
        }

        // GET: Klients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Klients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Klient klient)
        {
            if (ModelState.IsValid)
            {
                _context.Klient.Add(klient);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(klient);
        }

        // GET: Klients/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Klient klient = _context.Klient.Single(m => m.ID == id);
            if (klient == null)
            {
                return HttpNotFound();
            }
            return View(klient);
        }

        // POST: Klients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Klient klient)
        {
            if (ModelState.IsValid)
            {
                _context.Update(klient);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(klient);
        }

        // GET: Klients/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Klient klient = _context.Klient.Single(m => m.ID == id);
            if (klient == null)
            {
                return HttpNotFound();
            }

            return View(klient);
        }

        // POST: Klients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Klient klient = _context.Klient.Single(m => m.ID == id);
            _context.Klient.Remove(klient);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
