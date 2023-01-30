using System;

namespace ConsoleApp5
{
    class test
    {
        static void Main(string[] args)
        {
            int ali = 0, sum = 0;
            for (int i = 0; i < 1000; i++)

            {
                sum = sum + i;

                if (sum % 3 != 0 && sum % 5 != 0)
                {
                    Console.WriteLine(sum);


                }





            }
        }
    }
}
