using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Calculadora.ConsoleApp;

internal class Program
{
   
static string[] historicoOperacoes = new string[100]; 
static int contadorHistorico = 0;

    static void Main(string[] args)
    {       
        while (true) 
        {
            string opcao = ExibirMenu();

            if (OpcaoSairFoiEscolhida(opcao))
                break;

            else if (OpcaoTabuadaFoiEscolhida(opcao))
                ExibirTabuada();

            else if (OpcaoHistoricoFoiEscolhida(opcao))
            ExibirHistoricoDeOperacao();

            else
            {
                ExibirResultado(RealizarCalculo(opcao));
            }

            Console.WriteLine();

            Console.Write("Deseja continuar? (S/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
            break;                        
        }
    } 
      
    static string ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("--- Calculadora Tabajara 2025 ---");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("    1 - Somar");
        Console.WriteLine("    2 - Subtrair");
        Console.WriteLine("    3 - Multiplicar");
        Console.WriteLine("    4 - Divisão");
        Console.WriteLine("    5 - Tabuada");
        Console.WriteLine("    6 - Historico");
        Console.WriteLine("    S - Sair");

        Console.WriteLine();
        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine()!.ToUpper();
        return opcao;
    }

    static bool OpcaoSairFoiEscolhida(string opcao)
    {
        bool opcaoSairFoiEscolhida = opcao == "s";

        return opcaoSairFoiEscolhida;
    }

    static bool OpcaoTabuadaFoiEscolhida(string opcao)
    {
        bool opcaoTabuadaFoiEscolhida = opcao == "5";

        return opcaoTabuadaFoiEscolhida;
    }

    static bool OpcaoHistoricoFoiEscolhida(string opcao)
    {
        bool opcaoHistoricaFoiEscolhida = opcao == "6";

        return opcaoHistoricaFoiEscolhida;
    }

    static void ExibirTabuada()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("---------------------------");

        Console.Write("Digite o Numero: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for (int cont = 1; cont <= 10; cont++)
        {
            int resultadoTabuada = numeroTabuada * cont;
            Console.WriteLine($"{numeroTabuada} x {cont} = {resultadoTabuada}");
        }
        Console.ReadLine();
    }

    static void ExibirHistoricoDeOperacao()
    {

        Console.WriteLine("----------------------");
        Console.WriteLine("Historico de Operações");
        Console.WriteLine("----------------------");

        for (int contador = 0; contador < historicoOperacoes.Length; contador++)
        {
            string valorAtual = historicoOperacoes[contador];
            if (valorAtual != null)
                Console.WriteLine(historicoOperacoes[contador]);
        }

        Console.WriteLine("Pressione [Enter] para Continuar");
        Console.ReadLine();
    }

    static decimal RealizarCalculo(string operacao)
    {
        if(operacao == "1")
            Console.WriteLine("Operação selecionada: Soma.");
                     
        else if(operacao == "2")
            Console.WriteLine("Operação selecionada: Subtração.");

        else if (operacao == "3")
            Console.WriteLine("Operação selecionada: Multiplicação.");
  
        else            
            Console.WriteLine("Operação selecionada: Divisão.");
        
        Console.WriteLine();
        Console.Write("Digite o primeiro numero: ");
        decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

        decimal resultado = 0;

        if (operacao == "1")
        {
            resultado = Calculadora.Somar(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
        }
        else if (operacao == "2")
        {
            resultado = Calculadora.Subtrair(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
        }
        else if (operacao == "3")
        {
            resultado = Calculadora.Multiplicar(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
        }
        else if (operacao == "4")
        {
            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível dividir um numeor por zero.");
                Console.ReadLine();
            }
            resultado = Calculadora.Divisao(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
        }
        contadorHistorico += 1;

        return resultado;          
    }
    static void ExibirResultado(decimal resultado)
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Resultado = " + resultado.ToString("F3"));
        Console.WriteLine("---------------------------");
    }

}//Main
          
