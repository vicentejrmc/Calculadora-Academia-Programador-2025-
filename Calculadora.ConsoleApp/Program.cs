namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara 2025");

            Console.Write("Digite o primeiro numero: ");
            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString); 
                
            Console.Write("Digite o segundo numero: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = primeiroNumero + segundoNumero;

            Console.WriteLine("Resultado: " + resultado);

            Console.ReadLine();
        }
    }
}
