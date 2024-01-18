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
            Console.Write("El més gran entre els dos números és " + Maxim(num1, num2));
            Contador();
            break;
        case 2:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write("El màxim comú divisor és " + Mcm(num1, num2));
            Contador();
            break;
        case 5:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            Console.Write(Combinatori(num1));
            Contador();
            break;
        case 6:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            Console.Write(MajorDivisor(num1));
            Contador();
            break;
        case 7:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            Console.Write(NumPrimer(num1));
            Contador();
            break;

        case 8:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            Console.Write(NPrimers(num1));
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
        Console.Write("\nIndica el valor del primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        return num1;
    }

    static int DemenarSegonNumero()
    {
        int num2;
        Console.Write("\nIndica el valor del segon número: ");
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

    static int Mcm(int num1, int num2)
    {
        int mcm;

        Maxim(num1, num2);
        return num1;
    }

    static void Contador()
    {
        int contador = 4;

        Console.WriteLine("\n");
        Console.Write("Temps per tornar al menú: 5\r");
        while (contador >= 0)
        {
            Thread.Sleep(1000);
            Console.Write("Temps per tornar al menú: " + contador + "\r");
            contador--;
        }
    }
    static string NPrimers(int num1)
    {
        int contPrimers = 0;
        bool primer = true;
        string resposta = "Primers: ";
        for (int i = 1; contPrimers < num1; i++)
        {
            for (int z = 2; z < i && primer; z++)
            {
                if (i % z == 0)
                    primer = false;
            }
            if (primer)
            {
                Console.WriteLine(i);
                resposta = resposta + i + "/";
                contPrimers++;
            }
            primer = true;
        }
        return resposta;
    }
    static string NumPrimer(int num1)
    {
        bool primer = true;
        string resposta;
        for (int i = 2; i < num1 && primer; i++)
        {
            if (num1 % i == 0)
                primer = false;
        }
        if (primer) resposta = "El nombre introduit SI QUE ES un nombre primer.";
        else resposta = "EL nombre introduit NO ES un nombre primer.";
        return resposta;
    }
    static string MajorDivisor(int num1)
    {
        string resposta="El major divisor del nombre introduit es: ";
        int majorDivisor = 0;
        for (int i = num1 - 1; i > 1 && majorDivisor == 0; i--)
        {
            if (num1 % i == 0)
            {
                majorDivisor = i;
                resposta = resposta + i;
            }
        }
        return resposta;
    }
    static int Combinatori (int num1)
    {
        int combinatori=1;
        for (int cont=1; cont<=num1;cont++)
        {
            combinatori = combinatori * cont;
        }
        return combinatori;
    }

} while (!sortir);