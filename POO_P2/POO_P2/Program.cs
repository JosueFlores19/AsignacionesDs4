using POO_P2;                 // Importa el namespace principal del proyecto
using POO_P2.Models;          // Importa el namespace donde están los modelos definidos
using System.Text;            // Importa librerías para trabajar con texto

// Se crea un objeto de la clase ImprimirInfo, que sirve para mostrar información
var imprimirInfo = new ImprimirInfo();

// ====== CREACIÓN DE SUPER PODERES ======

// Poder: volar
var poderVolar = new SuperPoder();
poderVolar.nombre = "Volar";
poderVolar.descripcion = "Capacidad para volar y planear en el aire";
poderVolar.nivel = NivelPoder.Niveldos;

// Poder: superfuerza
var superfuerza = new SuperPoder();
superfuerza.nombre = "super fuerza";
superfuerza.nivel = NivelPoder.NivelTres;

// Poder: regeneración
var regeneracion = new SuperPoder();
regeneracion.nombre = "Regeneración";
regeneracion.nivel = NivelPoder.NivelTres;

// ====== CREACIÓN DEL SUPERHÉROE SUPERMAN ======
var superman = new SuperHeroe();

superman.id = 1;                         // Identificador
superman.nombre = "   Superman   ";      // Nombre con espacios
superman.identidadSecreta = "Clark kent"; // Identidad secreta
superman.ciudad = "Metropolis";          // Ciudad donde vive
superman.PuedeVolar = true;              // Superman puede volar

// Se imprime la información de Superman
imprimirInfo.ImprimirSuperHeroe(superman);

// Se crea una lista de superpoderes y se le asignan a Superman
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superfuerza);
superman.superPoderes = poderesSuperman;

// Superman usa sus poderes
string resultSuperpoder = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperpoder);

// Superman salva el mundo
string resultSalvarMundo = superman.salvarelmundo();
Console.WriteLine($"{resultSalvarMundo}");

// Superman salva la Tierra
string resultSalvarTierra = superman.salvaerLaTierra();
Console.WriteLine($"{resultSalvarTierra}");

// ====== CREACIÓN DEL ANTIHÉROE WOLVERINE ======
var wolverine = new AntiHeroe();
wolverine.id = 5;                         // Identificador
wolverine.nombre = "Wolverine";           // Nombre
wolverine.identidadSecreta = "Logan";     // Identidad secreta
wolverine.PuedeVolar = false;             // Wolverine no puede volar

// Se imprime la información de Wolverine
imprimirInfo.ImprimirSuperHeroe(wolverine);

// Se asignan poderes a Wolverine
List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superfuerza);
wolverine.superPoderes = poderesWolverine;

// Wolverine usa sus poderes
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

// Wolverine realiza una acción como anti-héroe
string accionAntiheroe = wolverine.realizarAccionDeAntiHeroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);

// ====== ENUMERACIÓN DE NIVELES DE PODER ======
enum NivelPoder
{
    Niveluno,   // Nivel básico
    Niveldos,   // Nivel intermedio
    NivelTres   // Nivel máximo
}

// ====== RECORD ======
// Un record para representar un superhéroe de forma inmutable y compacta
public record SuperheroeRecord(int id, string nombre, string identidadSecreta);