using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    // Clase abstracta que sirve como base para SuperHeroe y AntiHeroe
    internal abstract class Heroe
    {
        // Propiedad abstracta: obliga a las clases hijas a implementar "nombre"
        public abstract string nombre
        {
            get;
            set;
        }

        // Método abstracto: las clases hijas deben dar su propia implementación
        public abstract string salvarelmundo();

        // Método virtual: puede usarse tal cual o sobreescribirse en clases hijas
        public virtual string salvaerLaTierra()
        {
            return $"{nombre} ha salavado la tierra"; // Mensaje por defecto
        }
    }
}
