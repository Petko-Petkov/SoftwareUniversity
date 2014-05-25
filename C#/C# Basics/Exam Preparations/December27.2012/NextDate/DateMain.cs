namespace NextDate
{
    using System;

    class DateMain
    {
        static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            DateTime nextDate = date.AddDays(1);

            Console.WriteLine(nextDate.Day + "." + nextDate.Month + "." + nextDate.Year);
        }
    }
}
