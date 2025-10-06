using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeVideojuegosLinqs
{
    internal class Videojuego
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public double Precio { get; set; }
        public string Plataforma { get; set; }
        public double Calificacion { get; set; }
    }
}
