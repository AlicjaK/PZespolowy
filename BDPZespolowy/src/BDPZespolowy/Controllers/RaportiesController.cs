using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class RaportiesController : Controller
    {
        private ApplicationDbContext _context;

        public RaportiesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Raporties
        public IActionResult Index()
        {
            return View(_context.Raporty.ToList());
        }

        // GET: Raporties/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Raporty raporty = _context.Raporty.Single(m => m.ID == id);
            if (raporty == null)
            {
                return HttpNotFound();
            }

            return View(raporty);
        }

        // GET: Raporties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Raporties/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Raporty raporty)
        {
            if (ModelState.IsValid)
            {
                _context.Raporty.Add(raporty);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raporty);
        }

        // GET: Raporties/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Raporty raporty = _context.Raporty.Single(m => m.ID == id);
            if (raporty == null)
            {
                return HttpNotFound();
            }
            return View(raporty);
        }

        // POST: Raporties/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Raporty raporty)
        {
            if (ModelState.IsValid)
            {
                _context.Update(raporty);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raporty);
        }

        // GET: Raporties/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Raporty raporty = _context.Raporty.Single(m => m.ID == id);
            if (raporty == null)
            {
                return HttpNotFound();
            }

            return View(raporty);
        }

        // POST: Raporties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Raporty raporty = _context.Raporty.Single(m => m.ID == id);
            _context.Raporty.Remove(raporty);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
