using System;

// cambiar los valores entre true y flase para probar los operadores logicos
bool valor1 = true;
bool valor2 = true;
bool valor3 = true;

/* 
&& (and): Devuelve verdadero si ambos operandos son verdaderos.
|| (or): Devuelve verdadero si al menos uno de los operandos es verdadero.
! (not): Invierte el valor booleano del operando.
^ (xor): Devuelve verdadero si sólo uno de los operandos es verdadero.
*/

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

bool resultadoNot = !valor1;
Console.WriteLine(resultadoNot);

bool resultadoXor = valor1 ^ valor2; //XOR = not or (es decir lo opuesto a la or)
Console.WriteLine(resultadoXor);

// bool resultadoXor = (valor1 ^ valor2) ^ valor3; 
//XOR ^ XOR es decir primero saca el binario T/F de la primera Xor y luego lo compara con la segunda
// Console.WriteLine(resultadoXor);