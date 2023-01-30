using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime birthDay = new DateTime();
            DateTime today = DateTime.Today;

            Console.WriteLine("Enter your birthday like : 1379/01/01");
            birthDay = Convert.ToDateTime(Console.ReadLine());
            TimeSpan age = today.Subtract(birthDay);
            Console.WriteLine(age);
            int year = age.Days / 365;
            int month = (age.Days % 365) / 30;
            int day = (age.Days % 365) % 30;
            Console.WriteLine($"you have {year} year  nad {month} month and {day} days old");
            Console.ReadLine();
        }
    }
}