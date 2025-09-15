var (totalJugador, totalDealer, num) = (0, 0, 0);
string message = string.Empty;
string switchControl = "menu";
int sigueJugando = 0;

/* Blackjack, Juntar 21 pidiendo, en caso de pasaswte de 21 pierdes.
cartas o en caso de tener menos
de 21 igual tener mayor puntuación que el dealer */

while (true)
{
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Welcome al *** C A S I N O ***");
            Console.WriteLine("Escriba '21' para jugar 21");
            switchControl = Console.ReadLine();
            break;

        case "21":
            System.Random random = new System.Random();
            totalDealer = random.Next(1, 21);
            do
            {
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("Toma tu carta jugador");
                Console.WriteLine($"Te salió el número: {num}");
                Console.WriteLine("Deseas seguir jugando?");
                Console.WriteLine("1-> Si");
                Console.WriteLine("2-> No");
                sigueJugando = Convert.ToInt32(Console.ReadLine());
            }
            while (sigueJugando == 1);
            if (totalJugador < 1 || totalJugador > 21)
            {
                message = "Total jugador no puede ser menor que 1 o mayor a 21";
                switchControl = "menu";
            }
            else if (totalDealer < 1 || totalDealer > 21)
            {
                message = "Total dealer no puede ser menor que 1 o mayor a 21";
                switchControl = "menu";
            }
            else
            {
                if (totalJugador > totalDealer)
                {
                    message = "Felicidades, venciste al dealer";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Lo siento!... Perdiste vs el dealer";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condición no válida";
                    switchControl = "menu";
                }
            }
            Console.WriteLine($"Total jugador {totalJugador}");
            Console.WriteLine($"Total dealer {totalDealer}");
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("Valor ingresado no valido en el *** C A S I N O ***");
            switchControl = "menu";
            break;
    }
}