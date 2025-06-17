using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator
{
    public class Menu
    {


        public void showMenu()
        {
            Console.Clear();
            Console.WriteLine("🧮 CALCULADORA C#");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: "); 
        }
    }
}