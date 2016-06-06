using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class TerminsController : Controller
    {
        private ApplicationDbContext _context;

        public TerminsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Termins
        public IActionResult Index()
        {
            return View(_context.Termin.ToList());
        }

        // GET: Termins/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Termin termin = _context.Termin.Single(m => m.ID == id);
            if (termin == null)
            {
                return HttpNotFound();
            }

            return View(termin);
        }

        // GET: Termins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Termins/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Termin termin)
        {
            if (ModelState.IsValid)
            {
                _context.Termin.Add(termin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(termin);
        }

        // GET: Termins/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Termin termin = _context.Termin.Single(m => m.ID == id);
            if (termin == null)
            {
                return HttpNotFound();
            }
            return View(termin);
        }

        // POST: Termins/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Termin termin)
        {
            if (ModelState.IsValid)
            {
                _context.Update(termin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(termin);
        }

        // GET: Termins/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Termin termin = _context.Termin.Single(m => m.ID == id);
            if (termin == null)
            {
                return HttpNotFound();
            }

            return View(termin);
        }

        // POST: Termins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Termin termin = _context.Termin.Single(m => m.ID == id);
            _context.Termin.Remove(termin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
