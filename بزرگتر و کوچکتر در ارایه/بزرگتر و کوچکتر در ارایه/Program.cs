using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter count number's : \t");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int min = a[0], max = a[0];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter num {0} : \t", i);
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];

            }
            Console.Write("max is :\t{0} \nand min is :\t{1}", max, min);
            Console.ReadLine();
        }
    }
}
