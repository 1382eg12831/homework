using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; Console.WriteLine("Enter your number: ");
            n = Convert.ToInt32(Console.ReadLine()); tavan(n);
        }
        static void tavan(int n)
        {
            Console.WriteLine(Math.Pow(n, 2)); Console.WriteLine(Math.Pow(n, 3));
        }
    }
}