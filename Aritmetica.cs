public class Aritmetica
{
    public static double soma(double parcela1, double parcela2)
    {
        double Total = parcela1 + parcela2;
        return Total;

    }

    public static double Subtração(double minuendo1, double subtraendo2)
    {
        double diferenca = minuendo1 - subtraendo2;
        return diferenca;
    }

    public static double multiplicacao(double fator1, double fator2)
    {
        double produto = fator1 * fator2;
        return produto;
    }

    public static double Divisão(double dividendo1, double divisor2)
    {
        if (divisor2 == 0)
        {
            throw new Exception("Erro ao ter divisor 0");
        }

        double Quociente = dividendo1 / divisor2;
        return Quociente;
    }

    public static double Exponenciacao(double numero, double expoente)
    {
        double potencia = Math.Pow(numero, expoente);
        return potencia;
    }

    public static double Radiacao(double indice, double radicando)
    {
        double Raiz = Math.Pow(radicando, 1 / indice);
        return Raiz;
    }

}