using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for operation");
            int c = Int32.Parse(Console.ReadLine());

            switch (c)
            {
                case 1: Console.WriteLine(Add(a, b));break; // addition
                case 2: Console.WriteLine(Sub(a, b)); break; // substrction
                case 3: Console.WriteLine(Mult(a, b)); break; // multiplication
                case 4: Console.WriteLine(Div(a, b)); break; // division
                default: Console.WriteLine("Wrong number");break;
            }
        }



        static int Add(int a, int b)
        {
            return a+b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mult(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Illegal number");
                return 0;
            }
            else
            {
                return a + b;
            }
            
        }
    }
}
