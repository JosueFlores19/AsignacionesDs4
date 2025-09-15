int totalJugador = 0;
int totalDealer = 15;
string message = string.Empty;
Random rand = new Random(); // Funcion para dar un valor aleatorio
totalJugador = rand.Next(1, 21); // Le asigna un valor a jugador

if (totalJugador > totalDealer) {
    message = $"Venciste al dealer. Puntos = {totalJugador}";

}else if (totalJugador <= totalDealer) {
    message = $"Perdiste vs el dealer, lo siento. Puntos = {totalJugador}";

}else {
    message = "condición no válida";

}

Console.WriteLine(message);