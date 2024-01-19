int num1, num2;
bool sortir = false;
char opcio;
string textOpcio;

do
{
    Console.Clear();
    Console.WriteLine(Menu());

    Console.WriteLine("────────────────────");
    Console.Write("Introdueix una opció: ");
    opcio = Console.ReadKey().KeyChar;

    switch (opcio)
    {
        case '0' or 'q' or 'Q':
            sortir = true;
            break;
        case '1':
            textOpcio = "Màxim entre 2 núm.";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write(Maxim(num1, num2));
            Contador();
            break;
        case '2':
            textOpcio = "MCM";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write(Mcm(num1, num2));
            Contador();
            break;
        case '3':
            textOpcio = "MCD";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write(Mcd(num1, num2));
            Contador();
            break;
        case '4':
            textOpcio = "Factorial";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            Console.Write(Factorial(num1));
            Contador();
            break;
        case '5':
            textOpcio = "Combinatori";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            num2 = DemenarSegonNumero();
            Console.Write(Combinatori(num1, num2));
            Contador();
            break;
        case '6':
            textOpcio = "Major divisor";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            Console.Write(MajorDivisor(num1));
            Contador();
            break;
        case '7':
            textOpcio = "Validar núm. primer";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            Console.Write(NumPrimer(num1));
            Contador();
            break;
        case '8':
            textOpcio = "N. primers primers";
            Console.Clear();
            Console.WriteLine(Capcelera());
            Console.WriteLine(CapceleraOpcio(textOpcio));
            num1 = DemenarPrimerNumero();
            Console.Write(NPrimers(num1));
            Contador();
            break;
    }

    static string Menu()
    {
        string menu;

        Console.WriteLine(Capcelera());
        menu = "\x1b[43m\x1b[30m╔════════════════════════════════╗\n" +
               "║                                ║\n" +
               "║     1. Màxim de dos números    ║\n" +
               "║     ----------------------     ║\n" +
               "║     2. Mínim comú multiple     ║\n" +
               "║     ----------------------     ║\n" +
               "║     3. Màxim comú divisor      ║\n" +
               "║     ----------------------     ║\n" +
               "║     4. Factorial               ║\n" +
               "║     ----------------------     ║\n" +
               "║     5. Combinatori             ║\n" +
               "║     ----------------------     ║\n" +
               "║     6. Major divisor           ║\n" +
               "║     ----------------------     ║\n" +
               "║     7. Validar número primer   ║\n" +
               "║     ----------------------     ║\n" +
               "║     8. N. primers primers      ║\n" +
               "║                                ║\n" +
               "║     ----------------------     ║\n" +
               "║     \x1b[31m0. SORTIR\x1b[30m                  ║\n" +
               "║                                ║\n" +
               "╚════════════════════════════════╝\n\x1b[0m" ;


        return menu;
    }

    static string Capcelera()
    {
        string capcelera;

        capcelera = "\x1b[43m\x1b[30m╔════════════════════════════════╗\n" +
                    "║         \x1b[31mMENÚ MATEMÀTIC\x1b[30m         ║\n" +
                    "╚════════════════════════════════╝\x1b[0m";

        return capcelera;
    }

    static string CapceleraOpcio(string textOpcio)
    {
        string capceleraOpcio, linies = "";
        int contador;

        for (contador = 0; contador < textOpcio.Length; contador++)
        {
            linies = linies + "═";
        }

        capceleraOpcio = "╔══" + linies + "══╗\n" +
                         "║  " + textOpcio + "  ║\n" +
                         "╚══" + linies + "══╝";

        return capceleraOpcio;
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
        Console.Write("Indica el valor del segon número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        return num2;
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

    static string Maxim(int num1, int num2)
    {
        int auxiliar;
        string resposta = "\nEl més gran entre els dos números és: ";

        if (num1 < num2)
        {
            auxiliar = num1;
            num1 = num2;
            num2 = auxiliar;
        }

        return resposta + num1;
    }

    static string Mcm(int num1, int num2)
    {
        int mcm = 0, contador; 
        string resultat = "\nMínim comú multiple: ";

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
        string resultat = "\nFactorial: ";

        while (num1 > 0)
        {
            factorial = factorial * num1;
            num1--;
        }

        return resultat + factorial;
    }

    static double FactorialPerCombinatori(int num1)
    {
        int factorial = 1;

        while (num1 > 0)
        {
            factorial = factorial * num1;
            num1--;
        }

        return factorial;
    }

    static string Mcd(int num1, int num2)
    {
        int contador = 1, mcd = 0;
        string resultat = "\nMàxim comú divisor: ";

        while (contador <= num1 && contador <= num2)
        {
            if (num1 % contador == 0 && num2 % contador == 0)
                mcd = contador;

            contador++;
        }

        return resultat + mcd;
    }

    static string NPrimers(int num1)
    {
        int contPrimers = 0;
        bool primer = true;
        string resposta = "\nEls primers " + num1 + " num. primers: ";
        for (int i = 1; contPrimers < num1; i++)
        {
            for (int z = 2; z < i && primer; z++)
            {
                if (i % z == 0)
                    primer = false;
            }
            if (primer)
            {
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
        if (primer) resposta = "\nEl nombre introduït SI QUE ÉS un nombre primer.";
        else resposta = "\nEL nombre introduït NO ÉS un nombre primer.";
        return resposta;
    }

    static string MajorDivisor(int num1)
    {
        string resposta = "\nEl major divisor del nombre introduït és: ";
        int majorDivisor = 0;

        for (int i = num1 - 1; i > 1 && majorDivisor == 0; i--)
        {
            if (num1 % i == 0)
            {
                majorDivisor = i;
                resposta = resposta + i;
            }

        }
        if (majorDivisor == 0)
            resposta = resposta + 1;

        return resposta;
    }

    static string Combinatori(int num1, int num2)
    {
        double combinatori;
        string resposta = "\nCombinatori: ";
        combinatori = Math.Round(FactorialPerCombinatori(num1) / (FactorialPerCombinatori(num2) * FactorialPerCombinatori(num1 - num2)), 2);
        return resposta + combinatori;
    }

} while (!sortir);