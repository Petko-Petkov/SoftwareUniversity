/*Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. */

namespace DifferenceBetweenDates
{
    using System;

    class DaysMain
    {
        static void Main()
        {
            TimeSpan day;

            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            day = secondDate - firstDate;

            Console.WriteLine(Math.Abs(day.Days));
        }
    }
}
