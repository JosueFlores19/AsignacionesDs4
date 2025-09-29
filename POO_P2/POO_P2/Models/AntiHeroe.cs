using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    // Clase AntiHeroe que hereda de SuperHeroe
    internal class AntiHeroe : SuperHeroe
    {
        // Método propio del anti-héroe para realizar una acción
        public string realizarAccionDeAntiHeroe(string accion)
        {
            // Retorna un mensaje indicando qué acción hizo el anti-héroe
            return $"El Antiheroe {nombreIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
