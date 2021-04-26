using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMoqHandson1
{

    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                return firstNumber + secondNumber;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(5, 7));
        }
    }
}
