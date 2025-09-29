using POO_P2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2
{
    // Clase que se encarga de imprimir información de un superhéroe
    internal class ImprimirInfo
    {
        // Método que recibe un objeto que implemente ISuperHeroe
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            // Imprime en consola el ID del héroe
            Console.WriteLine($"ID: {superHeroe.id}");

            // Imprime en consola el nombre del héroe
            Console.WriteLine($"Nombre: {superHeroe.nombre}");

            // Imprime en consola la identidad secreta
            Console.WriteLine($"Identidad secreta: {superHeroe.identidadSecreta}");
        }
    }
}
