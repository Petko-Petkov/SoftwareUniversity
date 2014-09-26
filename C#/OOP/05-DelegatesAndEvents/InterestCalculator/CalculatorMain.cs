namespace InterestCalculator
{
    using System;

    class CalculatorMain
    {
        static void Main()
        {
            InterestCalculator compoundCalculations = new InterestCalculator(500, 5.6m, 10);
            var simpleCalculations = new InterestCalculator(2500, 7.2m, 15);

            Func<decimal, decimal, int, decimal> compoundCalc = compoundCalculations.GetCompoundInterest;
            Func<decimal, decimal, int, decimal> simpleCalc = simpleCalculations.GetSimpleInterest;

            Console.WriteLine("{0:0.0000}", compoundCalc(compoundCalculations.Money, compoundCalculations.Interest, compoundCalculations.Years));
            Console.WriteLine("{0:0.0000}", simpleCalc(simpleCalculations.Money, simpleCalculations.Interest, simpleCalculations.Years));
        }
    }
}
