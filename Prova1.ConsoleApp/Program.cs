using System;

namespace Prova1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoX, ladoY , ladoZ;
            string opcao;

            
            Console.WriteLine("Bem vindo\n");

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite 1 para inserir um triângulo e saber seu tipo.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite 2 para sair.");
                Console.ResetColor();
                opcao = Console.ReadLine();
                
                if (opcao != "1" && opcao != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida!\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (opcao != "1" && opcao != "2");
            
           
            Console.Write("\nDigite o valor do lado X: ");
            ladoX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Agora, digite o lado Y: ");
            ladoY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Em seguida, digite o lado Z: ");
            ladoZ = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            if (ladoX == ladoY && ladoY != ladoZ)
            {
                Console.WriteLine("Este é um triângulo isósceles (apenas dois lados iguais).\n");
            }
            else if (ladoX == ladoZ && ladoX != ladoY)
            {
                Console.WriteLine("Este é um triângulo isósceles (apenas dois lados iguais).\n");
            }
            else if (ladoY == ladoZ && ladoZ != ladoX)
            {
                Console.WriteLine("Este é um triângulo isósceles (apenas dois lados iguais).\n");
            }
            else if (ladoX != ladoY && ladoY != ladoZ)
            {
                Console.WriteLine("Este é um triângulo escaleno (todos os lados são diferentes).\n");
            }
            else if (ladoX == ladoY && ladoY == ladoZ)
            {
                Console.WriteLine("Este é um triângulo equilátero (todos os lados são iguais).\n");
            }
            Console.ResetColor();
            do
            {

                Console.WriteLine("\nDeseja fazer mais uma operação?");

                Console.Write("Digite 'Y' para SIM ");

                Console.Write("ou 'N' para NÃO: ");

                opcao = Console.ReadLine();

                if (opcao != "Y" && opcao != "N" && opcao != "y" && opcao != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("\nDigite uma tecla válida!");

                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (opcao != "Y" && opcao != "N" && opcao != "y" && opcao != "n");

            Console.ReadLine();
        }
    }
}
