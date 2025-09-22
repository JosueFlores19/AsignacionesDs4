// === Superhéroe de ejemplo ===
using System.Text;

var superman = new SuperHeroe();
superman.ID = 1;
superman.Nombre = "Superman";
superman.Superpoderes.Add("Super Fuerza");
superman.Superpoderes.Add("Volar");
superman.Superpoderes.Add("Visión de rayos X");
superman.PuedeVolar = true;

// === Uso del método UsarSuperpoderes (video 9) ===
string resultSuperman = superman.UsarSuperpoderes();
Console.WriteLine(resultSuperman);

// === Clase actualizada === video 10
public class SuperHeroe
{
    public string Nombre { get; set; }
    public List<string> Superpoderes { get; set; }
    public int ID { get; set; }
    public bool PuedeVolar { get; set; }

    // Constructor
    public SuperHeroe()
    {
        Superpoderes = new List<string>();
        PuedeVolar = false;
        ID = 1;
    }

    // Método agregado en el video 9
    public string UsarSuperpoderes()
    {
        var sb = new StringBuilder();
        foreach (var item in Superpoderes)
        {
            sb.AppendLine($"{Nombre} está usando el superpoder {item}!");
        }
        return sb.ToString();
    }
}