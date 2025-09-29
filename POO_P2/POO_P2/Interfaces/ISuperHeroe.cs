using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Interfaces
{
    // Interfaz que define el contrato básico para un superhéroe
    internal interface ISuperHeroe
    {
        // Identificador único del héroe
        int id { get; set; }

        // Nombre público del héroe
        string nombre { get; set; }

        // Identidad secreta (nombre real del héroe)
        string identidadSecreta { get; set; }
    }
}
