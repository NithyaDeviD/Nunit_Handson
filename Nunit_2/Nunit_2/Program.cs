using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_2
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
        public int AddTest(int firstNumber, int secondNumber)
        {



            return firstNumber + secondNumber;




        }
        public int Divide(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                return a > b ? (a / b) : (b / a);
            }
            else
            {
                return 0;
            }
        }
        public int Multiply(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                return a * b;
            }
            else
                return 0;
        }
        public int Subtract(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                return a > b ? (a - b) : (b - a);
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
        }
    }
}
