using System;
using System.Threading.Channels;
using calculator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var menu = new Menu();
            bool isProgramRunning = true;

            while (isProgramRunning)
            {
                menu.showMenu();
                var op = Console.ReadLine();

                if (op == "0")
                {
                    Console.WriteLine("Encerrando calculadora...");
                    isProgramRunning = false;
                    break;
                }

                if (op != "1" && op != "2" && op != "3" && op != "4")
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    continue; // volta para o topo do while, sem pedir números
                }

                try
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Digite o segundo número: ");
                    double n2 = double.Parse(Console.ReadLine() ?? "0");

                    double result = op switch
                    {
                        "1" => calc.Add(n1, n2),
                        "2" => calc.Subtract(n1, n2),
                        "3" => calc.Multiply(n1, n2),
                        "4" => calc.Divide(n1, n2),
                        _ => throw new ArgumentException("Opção inválida.")
                    };

                    Console.WriteLine($"Resultado: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar....");
                Console.ReadKey();
            }
        }
    }
}
