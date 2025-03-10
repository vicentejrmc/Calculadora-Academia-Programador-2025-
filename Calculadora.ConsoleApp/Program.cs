namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool representa um bit podedendo ser 0 ou 1, apenas um valor 

            while (true) //true == true dessa forma sempre será verdadeiro e só será quebrado o Loop quado
                // a condiçãode break; for executada. 
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("---------------------------");

                Console.WriteLine(" 1 - Somar");
                Console.WriteLine(" 2 - Subtrair");
                Console.WriteLine(" 3 - Multiplicar");
                Console.WriteLine(" 4 - Divisão");
                Console.WriteLine(" S - Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine().ToUpper(); // Converte para Maiúsculo         

                if (opcao == "S")
                {
                    break;
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
                }
                else if(opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if(opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if(opcao == "4")
                {
                    resultado = primeiroNumero / segundoNumero;
                }

                    Console.WriteLine("--------------------------");
                Console.WriteLine("Resultado = " + resultado.ToString("F3"));
                Console.WriteLine("---------------------------");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S") ;
                    break;  // Quantod a condição só tem uma linha não se é necessario o uso de{}
               
            }   

            // break; Também pode ser usado ao final de um laço de repetição while para quebrar o Loop
            // return; quebra o programa inteiro retornando para o Main, o break; quebra apenas o loop
        }

  
    }
}
