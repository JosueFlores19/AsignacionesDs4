using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    // Clase que representa un SuperPoder de un héroe o anti-héroe
    class SuperPoder
    {
        // Nombre del poder (ej: "Volar", "Super fuerza")
        public string nombre;

        // Descripción opcional del poder
        public string descripcion;

        // Nivel del poder (usa el enum NivelPoder definido en otro archivo)
        public NivelPoder nivel;

        // Constructor: inicializa el nivel en "Niveluno" por defecto
        public SuperPoder()
        {
            nivel = NivelPoder.Niveluno;
        }
    }

}
