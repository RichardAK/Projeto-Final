string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora Final ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[^] Exponenciação ");
Console.WriteLine("[r] Radiação");
Console.WriteLine("[S] Sobre");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Calculadora.CalcularSoma();
        break;
    case "-":
        Calculadora.CalcularSubtracao();
        break;
    case "*":
        Calculadora.CalcularMultiplicacao();
        break;
    case "/":
        Calculadora.CalcularDivisao();
        break;

    case "^":
        Calculadora.CalcularExponenciacao();
        break;

    case "r":
        Calculadora.CalcularRadiacao();
        break;

    case "S":
        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;

}

Console.Clear();

Console.Beep();
Console.Beep();
Console.Beep();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Atividade projeto final feito por Kauã Richard Azevedo Lira ");
Console.ResetColor();
Console.WriteLine("GitHub: RichardAK");


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nObrigado por utilizar nosso programa.");


Console.ResetColor();