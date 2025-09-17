

Console.WriteLine("veintiuno!");
int num = 0;
string Control = "";
string messahe = "";
string switchControl = "menu";
int totaljugador = 0;
int Dealer = 0;

while (true)
{
    
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Bienvenido al C A S I N O");
            Console.WriteLine("Escriba '21' para jugar al 21");
            switchControl = Console.ReadLine();
            break;
        case "21":
            Console.WriteLine("Toma tu primera carta, Jugador, ");
            do
            {
                System.Random random = new System.Random();
                num = random.Next(1, 11);
                totaljugador = totaljugador + num;
                Console.WriteLine("Toma tu carta, Jugador");
                Console.WriteLine("Te salio el número, " + num);
                Console.WriteLine("¿Deseas otra carta?");
                Control = Console.ReadLine();
            }
            while (Control == "SI" || Control == "si" || Control == "Si" || Control == "yes");
            System.Random random1 = new System.Random();
            Dealer = random1.Next(13, 23);
            Console.WriteLine("El Dealer tiene: " + Dealer);
            Console.WriteLine("Tu tienes: " + totaljugador);
            if (totaljugador > Dealer && totaljugador < 22)
            {
                messahe = "Venciste al Dealer, UwU";
                switchControl = "menu";

            }
            else if (totaljugador <= Dealer && Dealer <= 21)
            {
                messahe = "Perdiste vs el Dealer, XD";
                switchControl = "menu";
            }
            else if (totaljugador >= 22)
            {
                messahe = "JAJAJAJAJA, te pasaste";
                switchControl = "menu";
            }
            else if (Dealer >= 22 && totaljugador < 22)
            {
                messahe = "JAJAJAJAJA, Se paso el Dealer, tu ganaste";
                switchControl = "menu";
            }
            else
            {
                messahe = "Condición no válida";
            }

            Console.WriteLine(messahe);
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("Valor Ingresado no valido");
            switchControl = "menu";
            break;
    }
}