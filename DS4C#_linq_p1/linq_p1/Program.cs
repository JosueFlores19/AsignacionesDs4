// See https://aka.ms/new-console-template for more information
using linq_p1;

LinqQueries queries = new LinqQueries();

//Toda la colleción:
//ImprimirValores(queries.TodaColletion());

//Libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());

//Libros que tienen mas de 250 páginas y tienen en el titulo la palabra "in action"
//ImprimirValores(queries.LibrosConMas250PagConPalabrasInAction());

//Todos los libros tienen Status
//Console.WriteLine($"Todos los libros tienen status: - {queries.TodosLibrosTienenStatus()}");

//Si algun libro fue publicado en 2005
// Console.WriteLine($"Algun libro fue publicado en 2005?: - {queries.SiAlgunLibroPUblicado2005()}");

//Libros de Python
//ImprimirValores(queries.LibrosPython());

//Libros de Java
//ImprimirValores(queries.LibrosJavaPorNombreAscendente());

//Libros que tienen mas de 450 paginas ordenas por cantidad de página
//ImprimirValores(queries.Librosmas450pagOrdenadosPorNumPagDescendente());

//3 primero libros de java  publicados  recientemente
//ImprimirValores(queries.TresPrimerosLibrosOrdenadosPorFecha());

//Tercer y cuarto libro de mas de 400 páginas
//ImprimirValores(queries.TercerCuartoLibroDeMas499Pag());

//Tres primeros libros filtrados por select
ImprimirValores(queries.TresPrimerosLIbrosCollection());



void ImprimirValores(IEnumerable<Book> listdelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15} \n", "Titulo", "N.Paginas", "Fecha publicacion");
    foreach(var item in listdelibros)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
} 