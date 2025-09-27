using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user
            Console.WriteLine("Enter a year.");
            int year = int.Parse(Console.ReadLine());

            bool divBy4 = (year % 4 == 0);     // is it divisible by 4
            bool divBy100 = (year % 100 == 0); // is it divisible by 100
            bool divBy400 = (year % 400 == 0); // is it divisible by 400

            bool isLeapYear;

            if (divBy4)
            {
                if (divBy100)
                {
                    if (divBy400)
                        isLeapYear = true;
                    else
                        isLeapYear = false;
                }
                else
                {
                    isLeapYear = true; // divisible by 4 but not by 100
                }
            }
            else
            {
                isLeapYear = false; // not divisible by 4 at all
            }

            // Output using ternary
            Console.WriteLine($"\nYear entered: {year}");
            Console.WriteLine($"Divisible by 4: {(divBy4 ? "Yes" : "No")}");
            Console.WriteLine($"Divisible by 100: {(divBy100 ? "Yes" : "No")}");
            Console.WriteLine($"Divisible by 400: {(divBy400 ? "Yes" : "No")}");
            Console.WriteLine($"Leap year: {(isLeapYear ? "Yes" : "No")}");
        }
    }
}

