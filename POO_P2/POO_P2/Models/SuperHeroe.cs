using POO_P2.Interfaces;  // Importa la carpeta de Interfaces (ISuperHeroe está aquí)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    // Clase SuperHeroe hereda de Heroe e implementa la interfaz ISuperHeroe
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _nombre;   // Campo privado para almacenar el nombre "limpio"

        // Propiedad pública id con valor por defecto = 1
        public int id { get; set; } = 1;

        // Propiedad nombre sobreescribe la definida en Heroe (override)
        public override string nombre
        {
            get
            {
                return _nombre; // Devuelve el nombre ya procesado
            }
            set
            {
                // Se elimina espacios en blanco al inicio y final
                _nombre = value.Trim();
            }
        }

        // Propiedad de solo lectura que combina nombre y la identidad secreta
        public string nombreIdentidadSecreta
        {
            get
            {
                return $"{nombre} ({identidadSecreta})";
            }
        }

        // Identidad secreta del héroe
        public string identidadSecreta { get; set; }

        // Ciudad donde vive el superhéroe
        public string ciudad;

        // Lista de superpoderes asociados
        public List<SuperPoder> superPoderes;

        // Bandera que indica si puede volar
        public bool PuedeVolar;

        // Constructor: inicializa valores por defecto
        public SuperHeroe()
        {
            id = 1;
            superPoderes = new List<SuperPoder>(); // lista vacía
            PuedeVolar = false; // por defecto no vuela
        }

        // Método que hace que el héroe use todos sus poderes
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in superPoderes)
            {
                // Por cada poder agrega un mensaje a la cadena
                sb.Append($"{nombreIdentidadSecreta} esta usando el super poder {item.nombre} !! \n");
            }
            return sb.ToString(); // Devuelve la concatenación de todos los mensajes
        }

        // Sobreescribe el método salvarelmundo de la clase Heroe
        public override string salvarelmundo()
        {
            return $"{nombreIdentidadSecreta} ha salvado el mundo";
        }

        // Sobreescribe el método salvaerLaTierra de la clase Heroe
        public override string salvaerLaTierra()
        {
            // base.salvaerLaTierra() está comentado, se devuelve mensaje personalizado
            return $"{nombreIdentidadSecreta} ha salvado la tierra";
        }
    }
}
