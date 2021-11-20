using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("Enter number: ");
            n = int.Parse(Console.ReadLine());
            int m = n / 2;
            int temp = 0;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    temp = 1;
                }
            }
            if (temp != 1)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
            Console.ReadLine();
        }
    }
}
