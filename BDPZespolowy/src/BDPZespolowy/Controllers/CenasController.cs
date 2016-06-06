using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class CenasController : Controller
    {
        private ApplicationDbContext _context;

        public CenasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Cenas
        public IActionResult Index()
        {
            return View(_context.Cena.ToList());
        }

        // GET: Cenas/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Cena cena = _context.Cena.Single(m => m.ID == id);
            if (cena == null)
            {
                return HttpNotFound();
            }

            return View(cena);
        }

        // GET: Cenas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cenas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cena cena)
        {
            if (ModelState.IsValid)
            {
                _context.Cena.Add(cena);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cena);
        }

        // GET: Cenas/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Cena cena = _context.Cena.Single(m => m.ID == id);
            if (cena == null)
            {
                return HttpNotFound();
            }
            return View(cena);
        }

        // POST: Cenas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cena cena)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cena);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cena);
        }

        // GET: Cenas/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Cena cena = _context.Cena.Single(m => m.ID == id);
            if (cena == null)
            {
                return HttpNotFound();
            }

            return View(cena);
        }

        // POST: Cenas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Cena cena = _context.Cena.Single(m => m.ID == id);
            _context.Cena.Remove(cena);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
