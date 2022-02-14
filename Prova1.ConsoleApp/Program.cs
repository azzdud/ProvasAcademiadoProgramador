using System;

namespace Prova1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoX, ladoY, ladoZ;
            string opcao;
                        
            Console.WriteLine("Bem vindo(a)!");
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDigite 1 para inserir um triângulo e saber seu tipo.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite 2 para sair.");
                    Console.ResetColor();
                    opcao = Console.ReadLine();

                    if (opcao != "1" && opcao != "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDigite uma opção válida!\n");
                        Console.ResetColor();
                    }
                } while (opcao != "1" && opcao != "2");

                if (opcao == "2")
                {
                    break;
                }
                Console.Write("\nDigite o valor do lado X: ");
                ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Agora, digite o lado Y: ");
                ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Em seguida, digite o lado Z: ");
                ladoZ = Convert.ToInt32(Console.ReadLine());

                if (ladoX > ladoY + ladoZ)
                {
                    Console.WriteLine("\nTriângulo inválido.");
                }
                else if (ladoY > ladoX + ladoZ)
                {
                    Console.WriteLine("\nTriângulo inválido.");
                }
                else if (ladoZ > ladoY + ladoX)
                {
                    Console.WriteLine("\nTriângulo inválido.");
                }
                else if (ladoX == ladoY && ladoY != ladoZ)
                {
                    Console.WriteLine("Este é um triângulo isósceles (apenas dois lados iguais).");
                }
                else if (ladoX == ladoZ && ladoX != ladoY)
                {
                    Console.WriteLine("Este é um triângulo isósceles (apenas dois lados iguais).");
                }
                else if (ladoY == ladoZ && ladoZ != ladoX)
                {
                    Console.WriteLine("Este é um triângulo isósceles (apenas dois lados iguais).");
                }
                else if (ladoX != ladoY && ladoY != ladoZ)
                {
                    Console.WriteLine("Este é um triângulo escaleno (todos os lados são diferentes).");
                }
                else if (ladoX == ladoY && ladoY == ladoZ)
                {
                    Console.WriteLine("Este é um triângulo equilátero (todos os lados são iguais).");
                }
                
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
            } while (opcao == "Y" || opcao == "y");

            Console.ReadLine();
        }
    }
}
