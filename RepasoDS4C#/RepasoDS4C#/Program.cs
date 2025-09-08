// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Programa que calcula el área de un rectángulo
//Si se usa var 
//var ladoA
//var ladoB
// no recomendable si se sabe que tipos de datos se usara
// float ladoA
// float ladoB
// float Rectangulo


// Declaracion de variables 
int ladoA;
int ladoB;
int Rectangulo;

Console.WriteLine("Calcula el área de un rectángulo");
Console.WriteLine("Ingrese el lado A:");
ladoA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el lado B: ");
ladoB = Convert.ToInt32(Console.ReadLine());

Rectangulo = ladoA * ladoB;
Console.WriteLine("El lado A es de:" + ladoA + " El lado B es de:" + ladoB + " El área del rectángulo es: " + Rectangulo);