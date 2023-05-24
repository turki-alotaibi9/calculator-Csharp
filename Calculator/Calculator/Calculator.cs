using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {

        public void multiply()
        {

            Console.WriteLine("Welcome To The Multiplication Section");

            Console.WriteLine("Enter first  number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second  number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber * secondNumber; 
            Console.WriteLine("the result is "+result);

        }

        public void divide()
        {
            Console.WriteLine("Welcome To the division  Section");

            Console.WriteLine("Enter first  number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second  number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber / secondNumber;
            Console.WriteLine("the result is " + result);
        }
        public void subtract() {

            Console.WriteLine("Welcome To The Subtraction Section");

            Console.WriteLine("Enter first  number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second  number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber - secondNumber;
            Console.WriteLine("the result is " + result);
        }

        public void add() {

            Console.WriteLine("Welcome To The Add Section");

            Console.WriteLine("Enter first  number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second  number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("the result is " + result);

        }
    }
}
