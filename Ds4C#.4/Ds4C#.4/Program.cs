// var valor1 = 10, valor2 = 1, valor3 = 2;
var (valor1, valor2, valor3) = (10, 1, 2); // otras forma de declararlos

Console.WriteLine("Los valores son: " + valor1 + " " + valor2 + " " + valor3);

/*
    == igual a
    != diferente a
    > mayor que
    < menor que
    >= mayor o igual
    <= menor o igual
*/

bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado de la comparacion valor1 == valor2: " + resultado1);

bool resultado2 = valor1 != valor2;
Console.WriteLine("El resultado de la comparacion valor1 != valor2: " + resultado2);

bool resultado3 = valor1 > valor2;
Console.WriteLine("El resultado de la comparacion valor1 > valor2: " + resultado3);

bool resultado4 = valor1 < valor2;
Console.WriteLine("El resultado de la comparacion valor1 < valor2: " + resultado4);

bool resultado5 = valor1 >= valor2;
Console.WriteLine("El resultado de la comparacion valor1 >= valor2: " + resultado5);

bool resultado6 = valor1 <= valor2;
Console.WriteLine("El resultado de la comparacion valor1 <= valor2: " + resultado6);