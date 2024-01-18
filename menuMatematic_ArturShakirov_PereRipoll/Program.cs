int opcio, num1, num2;
bool sortir = false;

do
{
    Console.Clear();
    Menu();

    Console.Write("\n\nIntrodueix una opció: ");
    opcio = Convert.ToInt32(Console.ReadKey());

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
            Console.Write(Mcm(num1, num2));
            Contador();
            break;
        case 3:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write(Mcd(num1, num2));
            Contador();
            break;
        case 4:
            Console.Clear();
            Capcelera();
            num1 = DemenarPrimerNumero();
            Console.Write(Factorial(num1));
            Contador();
            break;
    }

    static void Menu()
    {
        Capcelera();
        Console.WriteLine("*    1. Màxim de dos números      *");
        Console.WriteLine("*    2. Mínim comú multiple       *");
        Console.WriteLine("*    3. Màxim comú divisor        *");
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

    static string Mcm(int num1, int num2)
    {
        int mcm = 0, contador; 
        string resultat = "Mínim comú multiple: ";

        contador = num1 * num2;

        while (contador >= num1 && contador >= num2)
        {
            if (contador % num1 == 0 && contador % num2 == 0)
                mcm = contador;

            contador--;
        }

        return resultat + mcm;
    }

    static string Factorial(int num1)
    {
        int factorial = 1;
        string resultat = "Factorial: ";

        while (num1 > 0)
        {
            factorial = factorial * num1;
            num1--;
        }

        return resultat + factorial;
    }

    static string Mcd(int num1, int num2)
    {
        int contador = 1, mcd = 0;
        string resultat = "Màxim comú divisor: ";

        while (contador <= num1 && contador <= num2)
        {
            if (num1 % contador == 0 && num2 % contador == 0)
                mcd = contador;

            contador++;
        }

        return resultat + mcd;
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

} while (!sortir);