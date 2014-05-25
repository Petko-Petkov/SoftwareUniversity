namespace MathExpression
{
    using System;
    
    class MathExpressionMain
    {
        static void Main()
        {
            var inputN = decimal.Parse(Console.ReadLine());
            var inputM = decimal.Parse(Console.ReadLine());
            var inputP = decimal.Parse(Console.ReadLine());
            decimal dec = 128.523123123M;
            decimal sin = (decimal)Math.Sin((double)((int)(inputM % 180)));
            
            var result = (inputN * inputN + 1 / (inputM * inputP) + 1337M) / (inputN - dec * inputP) + sin;

            Console.WriteLine("{0:0.000000}", result);
        }
    }
}
