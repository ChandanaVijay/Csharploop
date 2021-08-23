using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans, n1 = 0, n2 = 1,i,n3;
            Console.WriteLine("Enter a number:");
            ans = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            for(i = 2; i < ans; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
