using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int winnumber = rnd.Next(1, 100);
            Console.Write("Please enter number: ");
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            while(n != winnumber && times <= 7)
            {
                if (n > winnumber)
                {
                    Console.WriteLine("Wrong! The win number is lower then your number");
                    Console.Write("Please enter number again: ");
                    n = int.Parse(Console.ReadLine());
                    times++;
                }  
                else if (n < winnumber)
                {
                    Console.WriteLine("Wrong! The win number is higher then your number");
                    Console.Write("Please enter number again: ");
                    n = int.Parse(Console.ReadLine());
                    times++;
                }
            }
            if(times > 7 && n != winnumber)
            {
                Console.Write($"Sorry!! The win number is {winnumber}");
            }
            else
            {
                Console.Write($"Congratulation!! The win number is {n}");
            } 
                
            Console.ReadLine();
            
        }
    }
}
