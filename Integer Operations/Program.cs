using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float result;
            string x;
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("operator (+-*/): ");
            x = Console.ReadLine();
            switch (x)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine($"{a} + {b} = {result}");
                    break;
                case "-":
                    result = a - b;
                    Console.WriteLine($"{a} - {b} = {result}");
                    break;
                case "*":
                    result = a * b;
                    Console.WriteLine($"{a} * {b} = {result}");
                    break;
                case "/":
                    result = a / b;
                    Console.WriteLine($"{a} / {b} = {result}");
                    break;
            }
            Console.ReadLine();
        }
    }
}
