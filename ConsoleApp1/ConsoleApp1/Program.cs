using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1, i, n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial is\t" + fact);
        }
    }
}
