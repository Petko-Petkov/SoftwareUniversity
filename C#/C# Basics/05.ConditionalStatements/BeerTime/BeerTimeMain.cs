/*A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format 
 * “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and 
 * prints “beer time” or “non-beer time” according to the definition above or “invalid time” if th
 * e time cannot be parsed. Note that you may need to learn how to parse dates and times. */

namespace BeerTime
{
    using System;
    using System.Globalization;

    class BeerTimeMain
    {
        static void Main(string[] args)
        {
            DateTime beerTime;
            string dateFormat = "h:mm tt";
            string dateTime = Console.ReadLine();
            DateTime beerTimeStart = DateTime.Parse("13:00");
            DateTime beerTimeEnd = DateTime.Parse("3:00");

            try
            {
                beerTime = DateTime.ParseExact(dateTime, dateFormat, CultureInfo.InvariantCulture);

                if (beerTime >= beerTimeStart || beerTime <= beerTimeEnd)
                {
                    Console.WriteLine("Beer time");
                }
                else
                {
                    Console.WriteLine("Non-beer time");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
