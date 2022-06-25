public class Calculadora
{

    public static void CalcularSoma()
    {

        double a, b, resultado;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("--- Soma A+B ---\n");

        Console.ResetColor();

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.soma(a, b);

        Console.Beep();
        Console.WriteLine($"{a} somado com {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularSubtracao()
    {
        double a, b, resultado;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("--- Subtração A-B ---\n");

        Console.ResetColor();

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Subtração(a, b);

        Console.Beep();
        Console.WriteLine($"{a} subtraindo {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularMultiplicacao()
    {
        double a, b, resultado;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("--- Multiplicação A*B ---\n");

        Console.ResetColor();

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.multiplicacao(a, b);

        Console.Beep();
        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularDivisao()
    {
        double a, b, resultado;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("--- Divisão A/B ---\n");

        Console.ResetColor();

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("\nNão é possível dividir por zero.");
        }
        else
        {
            resultado = Aritmetica.Divisão(a, b);

            Console.Beep();
            Console.WriteLine($"{a} dividido por {b} é {resultado}");
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularExponenciacao()
    {
        double numero, expoente, potencia;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("---Exponenciação a^b---\n");

        Console.ResetColor();

        Console.Write("Digite o numero:");
        numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o expoente:");
        expoente = Convert.ToDouble(Console.ReadLine());

        potencia = Aritmetica.Exponenciacao(numero, expoente);

        Console.Beep();
        Console.WriteLine($"{numero} com o expeonte {expoente} é {potencia}");

        Console.WriteLine("\npressione uma tecla para continuar...");
        Console.ReadKey();

        return;

    }

    public static void CalcularRadiacao()
    {
        double raiz, radicando, indice;

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("---Radiação ArB---\n");

        Console.ResetColor();

        Console.Write("Digite o Radicando:");
        radicando = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o Indice:");
        indice = Convert.ToDouble(Console.ReadLine());

        raiz = Aritmetica.Radiacao(indice, radicando);

        Console.Beep();
        Console.WriteLine($"A raiz de {radicando} com o indice de {indice} é {raiz:n2}");

        Console.WriteLine("\npressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

}