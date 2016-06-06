using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class StanowiskoesController : Controller
    {
        private ApplicationDbContext _context;

        public StanowiskoesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Stanowiskoes
        public IActionResult Index()
        {
            return View(_context.Stanowisko.ToList());
        }

        // GET: Stanowiskoes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Stanowisko stanowisko = _context.Stanowisko.Single(m => m.ID == id);
            if (stanowisko == null)
            {
                return HttpNotFound();
            }

            return View(stanowisko);
        }

        // GET: Stanowiskoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stanowiskoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Stanowisko stanowisko)
        {
            if (ModelState.IsValid)
            {
                _context.Stanowisko.Add(stanowisko);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stanowisko);
        }

        // GET: Stanowiskoes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Stanowisko stanowisko = _context.Stanowisko.Single(m => m.ID == id);
            if (stanowisko == null)
            {
                return HttpNotFound();
            }
            return View(stanowisko);
        }

        // POST: Stanowiskoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Stanowisko stanowisko)
        {
            if (ModelState.IsValid)
            {
                _context.Update(stanowisko);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stanowisko);
        }

        // GET: Stanowiskoes/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Stanowisko stanowisko = _context.Stanowisko.Single(m => m.ID == id);
            if (stanowisko == null)
            {
                return HttpNotFound();
            }

            return View(stanowisko);
        }

        // POST: Stanowiskoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Stanowisko stanowisko = _context.Stanowisko.Single(m => m.ID == id);
            _context.Stanowisko.Remove(stanowisko);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
