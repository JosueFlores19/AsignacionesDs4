Console.WriteLine("Josue Flores ID!");
int altura = 182;
int edad = 20;
string nombre = "Josue Flores";
string informacion = "Nació en Santigo, es estudiante programacion, musica, dibujo y lenguas";
var hobby = "Artista";


string tarjetaDeIdentificacion = $"La información de {nombre} es la siguiente \nSu edad es {edad}\n" +
    $"su altura es de {altura} cms\nInformación relevante {informacion} \nademás, su hobby es ser: {hobby} ";

Console.WriteLine(tarjetaDeIdentificacion);