using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            if(num==0)
            {
                Console.WriteLine("The Number is Zero");
            }
            else if (num > 0)
            {

                Console.WriteLine("The Number is Positive");
                if(num%2==0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
            else
            {
                Console.WriteLine("The Number is Negative");
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
            Console.ReadKey();
        }
    }
}
