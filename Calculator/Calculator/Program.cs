using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();  

          
           while (true)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Welcome in My App ");
                Console.WriteLine("Select one ");
                Console.WriteLine("To multiply Two Numbers press 1");
                Console.WriteLine("To divide two numbers press 2");
                Console.WriteLine("To Subtract two numbers press 3");
                Console.WriteLine("To add two numbers press 4");
                int selectOption = Convert.ToInt32(Console.ReadLine());
               

                switch (selectOption)
                {

                    case 1:
                        cal.multiply();
                        break;
                    case 2:
                        cal.divide();
                        break;
                    case 3:
                        cal.subtract();
                        break;
                    case 4:
                        cal.add();
                        break;
                }

                
            }

        }
    }

    
}
