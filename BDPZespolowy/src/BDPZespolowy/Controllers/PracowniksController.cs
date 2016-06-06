using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class PracowniksController : Controller
    {
        private ApplicationDbContext _context;

        public PracowniksController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Pracowniks
        public IActionResult Index()
        {
            return View(_context.Pracownik.ToList());
        }

        // GET: Pracowniks/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Pracownik pracownik = _context.Pracownik.Single(m => m.ID == id);
            if (pracownik == null)
            {
                return HttpNotFound();
            }

            return View(pracownik);
        }

        // GET: Pracowniks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pracowniks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pracownik pracownik)
        {
            if (ModelState.IsValid)
            {
                _context.Pracownik.Add(pracownik);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pracownik);
        }

        // GET: Pracowniks/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Pracownik pracownik = _context.Pracownik.Single(m => m.ID == id);
            if (pracownik == null)
            {
                return HttpNotFound();
            }
            return View(pracownik);
        }

        // POST: Pracowniks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Pracownik pracownik)
        {
            if (ModelState.IsValid)
            {
                _context.Update(pracownik);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pracownik);
        }

        // GET: Pracowniks/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Pracownik pracownik = _context.Pracownik.Single(m => m.ID == id);
            if (pracownik == null)
            {
                return HttpNotFound();
            }

            return View(pracownik);
        }

        // POST: Pracowniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Pracownik pracownik = _context.Pracownik.Single(m => m.ID == id);
            _context.Pracownik.Remove(pracownik);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
