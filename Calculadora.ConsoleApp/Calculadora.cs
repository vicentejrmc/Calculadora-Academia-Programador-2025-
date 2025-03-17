namespace Calculadora.ConsoleApp;

public static class Calculadora // definir a classe como static.
{
    //atributos 
    static string[] historicoOperacoes = new string[100];
    static int contadorHistorico = 0;

    // Toda class por padrão é private - Para torna-la visível, precisa-se mudar para public.
    public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero + segundoNumero;
        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
        contadorHistorico += 1;
        return resultado;
    }

    public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero - segundoNumero;
        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
        contadorHistorico += 1;
        return resultado;
    }

    public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero * segundoNumero;
        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
        contadorHistorico += 1;
        return resultado;
    }

    public static decimal Divisao(decimal primeiroNumero, decimal segundoNumero)
    {
        decimal resultado = primeiroNumero / segundoNumero;
        historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
        contadorHistorico += 1;
        return resultado;
    }

    public static string[] ObterHistoricoDeOperacoes()
    {
        return historicoOperacoes;
    }


}
