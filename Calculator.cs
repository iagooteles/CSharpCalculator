using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return (double) a / b;
        }
    }
}