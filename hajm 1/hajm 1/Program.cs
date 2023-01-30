using System;

namespace ConsoleApp1
{
    class test
    {
        static void Main(string[] args)
        {
            int a, b, c, x;
            Console.WriteLine("enter number1 :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2 :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number3 :");
            c = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(Volom(a, b, c));

        }
        private static int Volom(int a, int b, int c)
        {
            return a * b * c;

        }
    }

}
