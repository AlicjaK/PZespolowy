using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BDPZespolowy.Models;

namespace BDPZespolowy.Controllers
{
    public class RezerwacjasController : Controller
    {
        private ApplicationDbContext _context;

        public RezerwacjasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Rezerwacjas
        public IActionResult Index()
        {
            return View(_context.Rezerwacja.ToList());
        }

        // GET: Rezerwacjas/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Rezerwacja rezerwacja = _context.Rezerwacja.Single(m => m.ID == id);
            if (rezerwacja == null)
            {
                return HttpNotFound();
            }

            return View(rezerwacja);
        }

        // GET: Rezerwacjas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rezerwacjas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Rezerwacja rezerwacja)
        {
            if (ModelState.IsValid)
            {
                _context.Rezerwacja.Add(rezerwacja);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rezerwacja);
        }

        // GET: Rezerwacjas/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Rezerwacja rezerwacja = _context.Rezerwacja.Single(m => m.ID == id);
            if (rezerwacja == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacja);
        }

        // POST: Rezerwacjas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Rezerwacja rezerwacja)
        {
            if (ModelState.IsValid)
            {
                _context.Update(rezerwacja);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rezerwacja);
        }

        // GET: Rezerwacjas/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Rezerwacja rezerwacja = _context.Rezerwacja.Single(m => m.ID == id);
            if (rezerwacja == null)
            {
                return HttpNotFound();
            }

            return View(rezerwacja);
        }

        // POST: Rezerwacjas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Rezerwacja rezerwacja = _context.Rezerwacja.Single(m => m.ID == id);
            _context.Rezerwacja.Remove(rezerwacja);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
