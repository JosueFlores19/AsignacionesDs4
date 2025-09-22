using System.Text;
using System.Collections.Generic;

// ================== CREACIÓN DE SUPERPODERES ==================
var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

// ================== CREACIÓN DE SUPERHÉROES ==================
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

// ================== COMPARACIÓN ENTRE OBJETOS ==================
Console.WriteLine(superman == superman2); // False porque son clases distintas en memoria

var superHeroeRecord1 = new SuperHeroeRecord(1, "Superman", "Clark Kent");
var superHeroeRecord2 = new SuperHeroeRecord(1, "Superman", "Clark Kent");
Console.WriteLine(superHeroeRecord1 == superHeroeRecord2); // True porque los records comparan por valor

// ================== ASIGNACIÓN DE PODERES ==================
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

superman.SuperPoderes = poderesSuperman;

// ================== USO DEL MÉTODO ==================
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);

// ================== CLASES ==================
class SuperHeroe
{
    public int Id = 1;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
    public bool PuedeVolar;

    public SuperHeroe()
    {
        // Constructor vacío, pero ya inicializa SuperPoderes arriba
    }

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Superhéroe: {Nombre}");
        sb.AppendLine("Poderes:");
        foreach (var poder in SuperPoderes)
        {
            sb.AppendLine($"- {poder.Nombre} (Nivel: {poder.Nivel})");
        }
        return sb.ToString();
    }
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

// ================== RECORD ==================
public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);
