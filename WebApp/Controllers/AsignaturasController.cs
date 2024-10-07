using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Infrastructure;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AsignaturasController : Controller
    {

        private readonly WebAppContext _context;
        public AsignaturasController(WebAppContext context)
        {
            _context = context;
        }
        // GET: AsignaturasController
        public ActionResult Index()
        {
            //var asignaturas = _context.Asignaturas.ToList();
            List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura
            {
                Id = 1,
                Nombre = "Matemáticas",
                Profesor = "Dr. Juan Pérez",
                Creditos = 6,
                Cuatrimestre = 1
            },
            new Asignatura
            {
                Id = 2,
                Nombre = "Programación",
                Profesor = "Ing. Ana López",
                Creditos = 8,
                Cuatrimestre = 2
            },
            new Asignatura
            {
                Id = 3,
                Nombre = "Física",
                Profesor = "Mtro. Carlos García",
                Creditos = 5,
                Cuatrimestre = 1
            },
            new Asignatura
            {
                Id = 4,
                Nombre = "Química",
                Profesor = "Dra. María Sánchez",
                Creditos = 7,
                Cuatrimestre = 3
            }
        };

            return View(asignaturas);
        }

        // GET: AsignaturasController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null || _context.Asignaturas == null) {
                return NotFound();
            }

            var asignatura = _context.Asignaturas.FirstOrDefault(m => m.Id == id);
            if ( asignatura == null) {
                return NotFound();
            }
            
            return View(asignatura);
        }

        // GET: AsignaturasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AsignaturasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Nombre,Profesor,Creditos,Cuatrimestre")] Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asignatura);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(asignatura);
        }

        // GET: AsignaturasController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null || _context.Asignaturas == null)
            {
                return NotFound();
            }

            var asignatura = _context.Asignaturas.Find(id);
            if (asignatura == null)
            {
                return NotFound();
            }
            return View(asignatura);
        }

        // POST: AsignaturasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Nombre,Profesor,Creditos,Cuatrimestre")] Asignatura asignatura)
        {
            if (id != asignatura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asignatura);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsignaturaExists(asignatura.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(asignatura);
        }

        // GET: AsignaturasController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null || _context.Asignaturas == null)
            {
                return NotFound();
            }

            var asignatura = _context.Asignaturas.Find(id);
            if (asignatura == null)
            {
                return NotFound();
            }
            return View(asignatura);
        }

        // POST: AsignaturasController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAsignatura(int id)
        {
            if (_context.Asignaturas == null)
            {
                return Problem("Entity set 'WebAppContext.Asignaturas'  is null.");
            }
            var asignatura = _context.Asignaturas.Find(id);
            if (asignatura != null)
            {
                _context.Asignaturas.Remove(asignatura);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool AsignaturaExists(int id)
        {
            return (_context.Asignaturas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
