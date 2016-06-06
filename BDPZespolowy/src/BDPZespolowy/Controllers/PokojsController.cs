using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class PokojsController : Controller
    {
        private ApplicationDbContext _context;

        public PokojsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Pokojs
        public IActionResult Index()
        {
            return View(_context.Pokoj.ToList());
        }

        // GET: Pokojs/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Pokoj pokoj = _context.Pokoj.Single(m => m.ID == id);
            if (pokoj == null)
            {
                return HttpNotFound();
            }

            return View(pokoj);
        }

        // GET: Pokojs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pokojs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pokoj pokoj)
        {
            if (ModelState.IsValid)
            {
                _context.Pokoj.Add(pokoj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pokoj);
        }

        // GET: Pokojs/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Pokoj pokoj = _context.Pokoj.Single(m => m.ID == id);
            if (pokoj == null)
            {
                return HttpNotFound();
            }
            return View(pokoj);
        }

        // POST: Pokojs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Pokoj pokoj)
        {
            if (ModelState.IsValid)
            {
                _context.Update(pokoj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pokoj);
        }

        // GET: Pokojs/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Pokoj pokoj = _context.Pokoj.Single(m => m.ID == id);
            if (pokoj == null)
            {
                return HttpNotFound();
            }

            return View(pokoj);
        }

        // POST: Pokojs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Pokoj pokoj = _context.Pokoj.Single(m => m.ID == id);
            _context.Pokoj.Remove(pokoj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
