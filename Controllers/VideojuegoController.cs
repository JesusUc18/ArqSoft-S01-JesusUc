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
                Titulo = "Grand Theft Auto: San Andreas",
                Genero = "Acción / Mundo Abierto",
                Ano = 2004,
                Consola = "PlayStation 2",
                Descripcion = "Juego de mundo abierto donde sigues la historia de CJ en una ciudad llena de misiones, crimen y libertad para explorar."
            },
            new Videojuego {
                Id = 2,
                Titulo = "Minecraft",
                Genero = "Sandbox / Supervivencia",
                Ano = 2011,
                Consola = "PC",
                Descripcion = "Juego donde puedes construir, explorar y sobrevivir en un mundo hecho de bloques, creando lo que quieras."
            },
            new Videojuego {
                Id = 3,
                Titulo = "Call of Duty: Modern Warfare 2",
                Genero = "Shooter / Guerra",
                Ano = 2009,
                Consola = "PlayStation 3",
                Descripcion = "Juego de disparos en primera persona con una campaña intensa y un multijugador muy famoso."
            },
            new Videojuego {
                Id = 4,
                Titulo = "FIFA 14",
                Genero = "Deportes / Fútbol",
                Ano = 2013,
                Consola = "PlayStation 3",
                Descripcion = "Juego de fútbol donde controlas equipos reales y compites en partidos con jugabilidad realista."
            },
            new Videojuego {
                Id = 5,
                Titulo = "Super Mario Bros.",
                Genero = "Plataformas",
                Ano = 1985,
                Consola = "NES",
                Descripcion = "Juego clásico donde Mario avanza por niveles saltando obstáculos y enemigos para rescatar a la princesa."
            },
            new Videojuego {
                Id = 6,
                Titulo = "Fortnite",
                Genero = "Battle Royale",
                Ano = 2017,
                Consola = "PlayStation 4",
                Descripcion = "Juego multijugador donde 100 jugadores compiten en una isla hasta que solo quede uno, con construcción y disparos."
            },
            new Videojuego {
                Id = 7,
                Titulo = "God of War",
                Genero = "Acción / Aventura",
                Ano = 2005,
                Consola = "PlayStation 2",
                Descripcion = "Juego donde Kratos lucha contra dioses y criaturas mitológicas en una historia llena de acción y venganza."
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
