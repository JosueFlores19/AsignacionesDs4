Console.WriteLine("veintiuno!");
int num = 0;
string Control = "";
string messahe = "";
string switchControl = "menu";
int platzicoins = 0;
int totaljugador = 0;
int Dealer = 0;

// 21
while (true)
{
    
    Console.WriteLine("Bienvenido al P L A T Z I N O");
    Console.WriteLine("Cunatos platzicoins desea? \n" + "ingresa un numero entero \n" + "Recuerda que necesitas una por ronda");
    platzicoins = int.Parse(Console.ReadLine());

    for (int i = 0; i <= platzicoins; i++)
    {
        totaljugador = 0;
        Dealer = 0;

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
                    num = random.Next(1, 12);
                    totaljugador = totaljugador + num;
                    Console.WriteLine("Toma tu carta, Jugador");
                    Console.WriteLine("Te salio el número, " + num);
                    Console.WriteLine("¿Deseas otra carta?");
                    Console.WriteLine("Si / No");
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
                break;
            default:
                Console.WriteLine("Valor Ingresado no valido");
                switchControl = "menu";
                break;

        }
    }
}