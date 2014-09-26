namespace FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get 
            {
                return this.numerator; 
            }

            set 
            {
                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentOutOfRangeException("Value must be in the range [" + long.MinValue + "..." + long.MaxValue + "]!");
                }

                this.numerator = value; 
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Value cannot be 0");
                }
                else if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentOutOfRangeException("Value must be in the range [" + long.MinValue + "..." + long.MaxValue + "]!");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator -(Fraction first, Fraction second) 
        {
            long numerator = (first.Numerator * second.Denominator) - (first.Denominator * second.Numerator);
            long denominator = first.Denominator * second.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            long numerator = (first.Numerator * second.Denominator) + (first.Denominator * second.Numerator);
            long denominator = first.Denominator * second.Denominator;

            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return ((decimal)this.Numerator / this.Denominator).ToString();
        }
    }
}
