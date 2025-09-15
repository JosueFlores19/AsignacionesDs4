// variables

int totalJugador = 25;
int totalMaquina = 15;
string mensaje = "";
string switchControl = "menu";

Console.WriteLine(" Bienvenido al casino online: ");
Console.WriteLine(" escriba 21 para entrar al juego: ");
switchControl = Console.ReadLine();

// Juego Blackjack

switch (switchControl)
{
    case "21":

        if (totalJugador > totalMaquina && totalJugador < 22)
        {
            mensaje = " Le ganaste a la maquina felicidades ";
        }
        else if (totalJugador >= 22)
        {
            mensaje = " Perdiste contra la maquina te pasaste de 21 ";
        }

        else if (totalJugador <= totalMaquina)
        {
            mensaje = " perdiste game over ";
        }
        else
        {
            mensaje = " condicion no valida ";
        }

        Console.WriteLine(mensaje);
        break;
    default:
        Console.WriteLine(" Valor ingresado no valido: ");
        break;
}