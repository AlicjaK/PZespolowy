using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class ZnizkisController : Controller
    {
        private ApplicationDbContext _context;

        public ZnizkisController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Znizkis
        public IActionResult Index()
        {
            return View(_context.Znizki.ToList());
        }

        // GET: Znizkis/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Znizki znizki = _context.Znizki.Single(m => m.ID == id);
            if (znizki == null)
            {
                return HttpNotFound();
            }

            return View(znizki);
        }

        // GET: Znizkis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Znizkis/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Znizki znizki)
        {
            if (ModelState.IsValid)
            {
                _context.Znizki.Add(znizki);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(znizki);
        }

        // GET: Znizkis/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Znizki znizki = _context.Znizki.Single(m => m.ID == id);
            if (znizki == null)
            {
                return HttpNotFound();
            }
            return View(znizki);
        }

        // POST: Znizkis/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Znizki znizki)
        {
            if (ModelState.IsValid)
            {
                _context.Update(znizki);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(znizki);
        }

        // GET: Znizkis/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Znizki znizki = _context.Znizki.Single(m => m.ID == id);
            if (znizki == null)
            {
                return HttpNotFound();
            }

            return View(znizki);
        }

        // POST: Znizkis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Znizki znizki = _context.Znizki.Single(m => m.ID == id);
            _context.Znizki.Remove(znizki);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
