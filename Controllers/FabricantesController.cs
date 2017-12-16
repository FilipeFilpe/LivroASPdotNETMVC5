
using System.Linq;
using LivroASPdotNETMVC5.Contexts;
using LivroASPdotNETMVC5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace LivroASPdotNETMVC5.Controllers
{
    public class FabricantesController : Controller
    {
        private readonly EFContext _context;
        
        public FabricantesController(EFContext context)
        {
            this._context = context;
        }

        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(_context.Fabricantes.OrderBy(c => c.Nome));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            _context.Fabricantes.Add(fabricante);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long? id)
        {
            if (id == null)
                return BadRequest(ModelState);

            Fabricante fabricante = _context.Fabricantes.Find(id);
            if (fabricante == null)  
                return View("Edit");

            return View(fabricante);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(fabricante).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fabricante);
        }

        public ActionResult Details(long id)
        {
            if (id == null)
                return BadRequest(ModelState);

            Fabricante fabricante = _context.Fabricantes.Find(id);
            if (fabricante == null)  
                return View("Index");

            return View(fabricante);
        }

        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return BadRequest(ModelState);
            }
            Fabricante fabricante = _context.Fabricantes.Find(id);
            if (fabricante == null)
            {
                return View("Delete");
            }

            return View(fabricante);
        }
    }
}