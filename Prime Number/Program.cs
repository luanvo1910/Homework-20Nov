using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int temp = 0;
            Console.Write("Prime numbers:");

            int i = 2;
            do
            {
                for (var j = 2; j <= n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        temp = 1;
                    }
                }
                if (temp != 1)
                {
                    Console.Write(i+",");
                }
                i++;
                temp = 0;
            } while (i <= n);
                
   
            Console.ReadLine();
        }
    }
}
