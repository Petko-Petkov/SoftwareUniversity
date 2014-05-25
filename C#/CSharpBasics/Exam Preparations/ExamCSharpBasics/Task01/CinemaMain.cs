namespace Task01
{
    using System;

    class CinemaMain
    {
        static void Main()
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int hallCapacity = rows * columns;
            decimal income = 0;

            switch (projection)
            {
                case "Premiere":
                    {
                        income = hallCapacity * 12m;
                    }
                    break;
                case "Normal":
                    {
                        income = hallCapacity * 7.5m;
                    }
                    break;
                case "Discount":
                    {
                        income = hallCapacity * 5m;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0:F2} leva", income);
        }
    }
}
