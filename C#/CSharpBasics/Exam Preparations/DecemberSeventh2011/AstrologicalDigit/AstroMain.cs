namespace AstrologicalDigit
{
    using System;

    class AstroMain
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = CalculateAstroDigit(input);

            if (result.Length > 1)
            {
                result = CalculateAstroDigit(result);
            }

            Console.WriteLine(result);
        }

        private static string CalculateAstroDigit(string input)
        {
            var result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    continue;
                }
                else if (input[i] == '-')
                {
                    continue;
                }
                result += Math.Abs(input[i]) - 48;
            }
            
            return result.ToString();
        }
    }
}
