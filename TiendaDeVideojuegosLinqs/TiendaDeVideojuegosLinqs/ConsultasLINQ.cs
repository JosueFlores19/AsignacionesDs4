using System;
using System.Collections.Generic;
using System.Linq;
using TiendaDeVideojuegosLinqs;

namespace TiendaVideojuegosLINQ
{
    internal class ConsultasLINQ
    {
        private List<Videojuego> juegos;

        public ConsultasLINQ()
        {
            // Colección inicial
            juegos = new List<Videojuego>()
            {
                new Videojuego { Id = 1, Titulo = "The Legend of Zelda: Tears of the Kingdom", Genero = "Aventura", Precio = 70, Plataforma = "Nintendo Switch", Calificacion = 9.8 },
                new Videojuego { Id = 2, Titulo = "God of War Ragnarok", Genero = "Acción", Precio = 60, Plataforma = "PlayStation", Calificacion = 9.5 },
                new Videojuego { Id = 3, Titulo = "Minecraft", Genero = "Construcción", Precio = 30, Plataforma = "Multiplataforma", Calificacion = 9.0 },
                new Videojuego { Id = 4, Titulo = "Elden Ring", Genero = "RPG", Precio = 65, Plataforma = "Multiplataforma", Calificacion = 9.7 },
                new Videojuego { Id = 5, Titulo = "Super Mario Odyssey", Genero = "Plataformas", Precio = 55, Plataforma = "Nintendo Switch", Calificacion = 9.3 },
                new Videojuego { Id = 6, Titulo = "Halo Infinite", Genero = "Disparos", Precio = 50, Plataforma = "Xbox", Calificacion = 8.8 },
                new Videojuego { Id = 7, Titulo = "Hades", Genero = "Roguelike", Precio = 25, Plataforma = "PC", Calificacion = 9.1 },
                new Videojuego { Id = 8, Titulo = "Spider-Man 2", Genero = "Acción", Precio = 70, Plataforma = "PlayStation", Calificacion = 9.6 },
                new Videojuego { Id = 9, Titulo = "Stardew Valley", Genero = "Simulación", Precio = 15, Plataforma = "Multiplataforma", Calificacion = 8.9 },
                new Videojuego { Id = 10, Titulo = "Cyberpunk 2077", Genero = "RPG", Precio = 60, Plataforma = "PC", Calificacion = 8.5 }
            };
        }

        public void EjecutarConsultas()
        {
            // WHERE
            var juegosCaros = juegos.Where(j => j.Precio > 50);
            Console.WriteLine("WHERE: Videojuegos con precio mayor a $50");
            foreach (var j in juegosCaros)
                Console.WriteLine($"{j.Titulo} - ${j.Precio}");
            Console.WriteLine("Filtra los juegos cuyo precio es mayor a 50.\n");

            // ORDERBY
            var juegosOrdenados = juegos.OrderBy(j => j.Calificacion);
            Console.WriteLine("ORDERBY: Videojuegos ordenados por calificación ascendente");
            foreach (var j in juegosOrdenados)
                Console.WriteLine($"{j.Titulo} - Calificación: {j.Calificacion}");
            Console.WriteLine("Ordena desde la calificación más baja hasta la más alta.\n");

            // ORDERBYDESCENDING
            var juegosMejorCalificados = juegos.OrderByDescending(j => j.Calificacion);
            Console.WriteLine("ORDERBYDESCENDING: Mejores calificados");
            foreach (var j in juegosMejorCalificados)
                Console.WriteLine($"{j.Titulo} - Calificación: {j.Calificacion}");
            Console.WriteLine("Muestra primero los juegos con mayor calificación.\n");

            // TAKE
            var tresMasCaros = juegos.OrderByDescending(j => j.Precio).Take(3);
            Console.WriteLine("TAKE: Los 3 videojuegos más caros");
            foreach (var j in tresMasCaros)
                Console.WriteLine($"{j.Titulo} - ${j.Precio}");
            Console.WriteLine("Usa Take(3) para obtener los tres con precio más alto.\n");

            // SKIP + TAKE
            var saltarDos = juegos.Skip(2).Take(3);
            Console.WriteLine("SKIP + TAKE: Omitir los 2 primeros y tomar los siguientes 3");
            foreach (var j in saltarDos)
                Console.WriteLine($"{j.Titulo} - ${j.Precio}");
            Console.WriteLine("Skip(2) salta los dos primeros y Take(3) toma los siguientes tres.\n");

            // SELECT
            var titulosYPrecios = juegos.Select(j => new { j.Titulo, j.Precio });
            Console.WriteLine("SELECT: Mostrar solo título y precio");
            foreach (var j in titulosYPrecios)
                Console.WriteLine($"{j.Titulo} - ${j.Precio}");
            Console.WriteLine("Crea una nueva lista mostrando únicamente el título y el precio.\n");

            // CONSULTA ENCADENADA
            var mejoresAccion = juegos
                .Where(j => j.Genero == "Acción")
                .OrderByDescending(j => j.Calificacion)
                .Take(3)
                .Select(j => new { j.Titulo, j.Calificacion });

            Console.WriteLine("CONSULTA ENCADENADA: Top 3 juegos de acción");
            foreach (var j in mejoresAccion)
                Console.WriteLine($"{j.Titulo} - Calificación: {j.Calificacion}");
            Console.WriteLine("Combina varios operadores en una sola consulta.\n");
        }
    }
}
