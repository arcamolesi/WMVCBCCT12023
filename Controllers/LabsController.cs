using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WMVCBCCT12023.Models;

namespace WMVCBCCT12023.Controllers
{
    public class LabsController : Controller
    {
        private readonly Contexto _context;

        public LabsController(Contexto contexto)
        {
            _context = contexto;
        }


        // GET: Salas
        public async Task<IActionResult> Index()
        {
            ViewData["empresa"] = "FEMA";
            return View(await _context.Salas.ToListAsync());
        }

        //get
        public IActionResult Create()
        {

            var status = Enum.GetValues(typeof(Situacao))
            .Cast<Situacao>()
            .Select(e => new SelectListItem
            {
                Value = e.ToString(),
                Text = e.ToString()
            });

            ViewBag.bagSituacao = status;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao,quantidade,situacao")] Sala sala)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sala);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sala);
        }



    }
}
