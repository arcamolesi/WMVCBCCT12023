using Microsoft.AspNetCore.Mvc;
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
            return View(await _context.Salas.ToListAsync());
        }

    }
}
