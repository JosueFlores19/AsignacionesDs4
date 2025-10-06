using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace linq_p1
{
    internal class LinqQueries
    {
        private List<Book> librosCollection = new List<Book>();
        // "p" es una variable centinela o dicho de otra forma una variable temporal la cual hace referencia a los libros

        public LinqQueries()
        {
            // Lee el archivo JSON y lo convierte a una lista de objetos Book
            using (StreamReader reader = new StreamReader("books.json"))
            {
                string json = reader.ReadToEnd();
                this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json,
                    new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        // Muestra toda la colección de libros
        public IEnumerable<Book> TodaColletion()
        {
            return librosCollection;
        }

        // Reto 1 (Where): Libros publicados después del año 2000
        public IEnumerable<Book> LibrosDespuesdel2000()
        {
            return from l in librosCollection
                   where l.PublishedDate.Year > 2000
                   select l;
        }

        // Reto 2 (Where + Contains): Libros con más de 250 páginas y con "in Action" en el título
        public IEnumerable<Book> LibrosConMas250PagConPalabrasInAction()
        {
            return from l in librosCollection
                   where l.PageCount > 250 && l.Title.Contains("in Action")
                   select l;
        }

        // Reto 3 (All): Verifica si todos los libros tienen un valor en Status
        public bool TodosLibrosTienenStatus()
        {
            return librosCollection.All(p => p.Status != string.Empty);
        }

        // Reto 4 (Any): Comprueba si hay al menos un libro publicado en 2005
        public bool SiAlgunLibroPUblicado2005()
        {
            return librosCollection.Any(p => p.PublishedDate.Year == 2005);
        }

        // Reto 5 (Where + Contains): Filtra los libros que pertenecen a la categoría "Python"
        public IEnumerable<Book> LibrosPython()
        {
            return librosCollection.Where(p => p.Categories.Contains("Python"));
        }

        // Reto 6 (Where + OrderBy): Libros de Java ordenados alfabéticamente por título
        public IEnumerable<Book> LibrosJavaPorNombreAscendente()
        {
            return librosCollection
                .Where(p => p.Categories.Contains("Java"))
                .OrderBy(p => p.Title);
        }

        // Reto 7 (Where + OrderByDescending): Libros con más de 450 páginas, de mayor a menor
        public IEnumerable<Book> Librosmas450pagOrdenadosPorNumPagDescendente()
        {
            return librosCollection
                .Where(p => p.PageCount > 450)
                .OrderByDescending(p => p.PageCount);
        }

        // Reto 8 (Where + OrderByDescending + Take): Muestra los 3 libros más recientes de "Java"
        public IEnumerable<Book> TresPrimerosLibrosOrdenadosPorFecha()
        {
            return librosCollection
                .Where(p => p.Categories.Contains("Java"))
                .OrderByDescending(p => p.PublishedDate)
                .Take(3);
        }

        // Reto 9 (Where + Take + Skip): Obtiene el 3° y 4° libro con más de 400 páginas
        public IEnumerable<Book> TercerCuartoLibroDeMas499Pag()
        {
            return librosCollection
                .Where(p => p.PageCount > 400)
                .Take(4)
                .Skip(2); // Omite los dos primeros
        }

        // Extra (Take + Select): Muestra solo título y páginas de los 3 primeros libros
        public IEnumerable<Book> TresPrimerosLIbrosCollection()
        {
            return librosCollection
                .Take(3)
                .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount });
        }
    }
}
