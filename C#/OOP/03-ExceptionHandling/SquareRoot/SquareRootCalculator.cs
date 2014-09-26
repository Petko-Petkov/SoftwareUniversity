namespace SquareRoot
{
    using System;

    public static class SquareRootCalculator
    {
        public static void Check(string input)
        {
            try
            {
                double d = double.Parse(input);
                if (d < 0)
                {
                    throw new ArgumentOutOfRangeException("Number", "Invalid number");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(d));
                }
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("Invalid number", formatEx);
            }
            catch (ArgumentNullException nullEx)
            {
                Console.WriteLine("Invalid number", nullEx);
            }
            finally
            {
                System.Console.WriteLine("Good bye");
            }
        }
    }
}
