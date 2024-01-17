int opcio, num1, num2;
bool sortir = false;

do
{
    Console.Clear();
    Menu();

    Console.Write("\n\nIntrodueix una opció: ");
    opcio = Convert.ToInt32(Console.ReadLine());

    switch (opcio)
    {
        case 0:
            sortir = true;
            break;
        case 1:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write(Maxim(num1, num2));
            Contador();
            break;
    }

    static void Menu()
    {
        Capcelera();
        Console.WriteLine("*    1. Màxim de dos números      *");
        Console.WriteLine("*    2. Màxim comú divisor        *");
        Console.WriteLine("*    3. Mínim comú divisor        *");
        Console.WriteLine("*    4. Factorial                 *");
        Console.WriteLine("*    5. Combinatori               *");
        Console.WriteLine("*    6. Mostrar major divisor     *");
        Console.WriteLine("*    7. Número primer             *");
        Console.WriteLine("*    8. N.Primers primers         *");
        Console.WriteLine("*                                 *");
        Console.WriteLine("*    0. Sortir                    *");
        Console.WriteLine("***********************************");
    }

    static void Capcelera()
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("*         MENÚ MATEMÀTIC          *");
        Console.WriteLine("***********************************");
    }

    static int DemenarPrimerNumero()
    {
        int num1;
        Console.Write("\nIndica valor del primer número:");
        num1 = Convert.ToInt32(Console.ReadLine());

        return num1;
    }

    static int DemenarSegonNumero()
    {
        int num2;
        Console.Write("\nIndica valor del segon número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        return num2;
    }

    static int Maxim(int num1, int num2)
    {
        int auxiliar;

        if (num1 < num2)
        {
            auxiliar = num1;
            num1 = num2;
            num2 = auxiliar;
        }

        return num1;
    }

    static void Contador()
    {
        int contador = 5;

        Console.WriteLine("\n");
        while (contador >= 0)
        {
            Thread.Sleep(1000);
            Console.Write("Time remaining: " + contador + "\r");
            contador--;
        }
    }

} while (!sortir);