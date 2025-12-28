using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba_tecnica_cristian_varon_biblioteca.Models;

namespace prueba_tecnica_cristian_varon_biblioteca.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly GestorBibliotecaContext _context;

        public HomeController(GestorBibliotecaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalLibros = await _context.Libros.CountAsync();
            ViewBag.TotalAutores = await _context.Autores.CountAsync();

            return View();
        }
    }
}
