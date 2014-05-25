/*Create a console application that prints the current date and time. Find in Internet how.*/

namespace CurrentDate
{
    using System;

    class CurrentDateMain
    {
        static void Main()
        {
            DateTime currentDate = DateTime.Now;

            Console.WriteLine(currentDate);
        }
    }
}
