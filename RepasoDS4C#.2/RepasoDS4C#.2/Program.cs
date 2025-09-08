// See https://aka.ms/new-console-template for more information

var radio = 0d;
var resultado = 0d;

// declaraciones de constantes, siempre empezar con Mayusculas las constantes
const double Pi = 3.14;

Console.WriteLine("Bienvenido, calculemos circulos");
// Pi * radio * radio

Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToInt32(Console.ReadLine());

resultado = Math.PI * radio *radio;
// resultado = Pi * radio * radio;
// usando la constante

Console.WriteLine("El area del circulo es de: " + resultado); 
