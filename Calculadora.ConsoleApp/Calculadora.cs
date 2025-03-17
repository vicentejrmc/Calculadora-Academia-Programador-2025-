namespace Calculadora.ConsoleApp;

public static class Calculadora // definir a classe como static.
{
    // Toda Class por padrão é privat - Para torna-la visível, precisa-se mudar para public.
   public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero + segundoNumero;

        return resultado;
    }

    public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero - segundoNumero;

        return resultado;
    }

    public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero * segundoNumero;

        return resultado;
    }

    public static decimal Divisao(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero / segundoNumero;

        return resultado;
    }


}
