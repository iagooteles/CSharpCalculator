using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("Soma: " + calc.Add(5, 3));
            Console.WriteLine("Subtração: " + calc.Subtract(10, 4));
            Console.WriteLine("Multiplicação: " + calc.Multiply(6, 7));
            Console.WriteLine("Divisão: " + calc.Divide(20, 4));
        }
    }
}
