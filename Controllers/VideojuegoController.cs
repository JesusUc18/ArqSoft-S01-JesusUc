using MiProyecto.Models;
using Microsoft.AspNetCore.Mvc;
namespace MiProyecto.Controllers
{
    public class VideojuegoController : Controller
    {
        private static List<Videojuego> _items = new()
        {
            new Videojuego {
                Id = 1,
                Titulo = "Devil May Cry",
                Genero = "Hack and Slash",
                Ano = 2001,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            },
            new Videojuego {
                Id = 2,
                Titulo = "Castlevania: Symphony of the Night",
                Genero = "Metroidvania",
                Ano = 2007,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            }
        };


        // Lista — con filtro opcional por género
        public IActionResult Index(string? genero)
        {
            var resultado = string.IsNullOrEmpty(genero)
            ? _items
            : _items.Where(i => i.Genero == genero).ToList();
            ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
            ViewBag.GeneroActual = genero;
            return View(resultado);
        }

        // Detalle
        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            return item == null ? NotFound() : View(item);
        }

        // Formulario — GET
        public IActionResult Agregar()
        {
            return View();
        }

        // Formulario — POST
        [HttpPost]
        public IActionResult Agregar(Videojuego item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
            return RedirectToAction("Index");
        }
    }
}
