using System.Threading.Channels;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool representa um bit podedendo ser 0 ou 1, apenas um valor
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

            while (true) //true == true dessa forma sempre será verdadeiro e só será quebrado o Loop quado
                // a condiçãode break; for executada. ** Porém, ao usar dessa forma deve-se ter mais atenção**
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("---------------------------");

                Console.WriteLine(" 1 - Somar");
                Console.WriteLine(" 2 - Subtrair");
                Console.WriteLine(" 3 - Multiplicar");
                Console.WriteLine(" 4 - Divisão");
                Console.WriteLine(" 5 - Tabuada");
                Console.WriteLine(" 6 - Historico");
                Console.WriteLine(" S - Sair");
               
                
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine().ToUpper(); // Converte para Maiúsculo

                    if (opcao == "S")
                {
                    break;
                }
                else if(opcao == "5")
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("---------------------------");

                    Console.Write("Digite o Numero: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    
                    for(int cont = 1; cont <= 10; cont++)
                    {
                        // string LinhaTabuada = numeroTabuada + " X " + cont + " = " + resultadoTabuada;
                        int resultadoTabuada = numeroTabuada * cont;
                        Console.WriteLine($"{numeroTabuada} x {cont} = {resultadoTabuada}");
                    }
                    Console.ReadLine();
                    continue;
                }
                else if (opcao == "6")
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Historico de Operações");
                    Console.WriteLine("----------------------");
                    
                    for(int contador = 0; contador < historicoOperacoes.Length; contador++)
                    {
                        string valorAtual = historicoOperacoes[contador];
                        if(valorAtual != null)
                            Console.WriteLine(historicoOperacoes[contador]);
                    }

                    Console.WriteLine("Pressione [Enter] para Continuar");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro numero: ");
                string primeiroNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o segundo numero: ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());


                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if(opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                }
                else if(opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                }
                else if(opcao == "4")
                {
                    if(segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir um numeor por zero.");
                        Console.ReadLine();
                        continue; // Retorna o codigo para o inicio do loop
                    }
                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                }

                contadorHistorico += 1;
                
                    Console.WriteLine("--------------------------");
                Console.WriteLine("Resultado = " + resultado.ToString("F3"));
                Console.WriteLine("---------------------------");              
                

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;  // Quando a condição só tem uma linha não se é necessario o uso de{}
               
            }   

            // break; Também pode ser usado ao final de um laço de repetição while para quebrar o Loop
            // return; quebra o programa inteiro retornando para o Main, o break; quebra apenas o loop
        } 
    }
}
