namespace InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        #region Fields

        private decimal money;
        private decimal interest;
        private int years;

        #endregion

        #region Constructors

        public InterestCalculator(decimal money, decimal interest, int years)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
        }

        #endregion

        #region Properties

        public decimal Money
        {
            get 
            {
                return this.money; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Money cannot have a negative value");
                }

                this.money = value; 
            }
        }

        public decimal Interest
        {
            get 
            {
                return this.interest; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative");
                }

                this.interest = value; 
            }
        }
        
        public int Years
        {
            get 
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years cannot be negative");
                }

                this.years = value;
            }
        }

        #endregion

        #region Methods

        public decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal simple = sum * (1 + (interest * (decimal)years / 100));

            return simple;
        }

        public decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal compound = sum * (decimal)(Math.Pow(1 + ((double)interest / 12 / 100), years * 12));

            return (decimal)compound;
        }

        #endregion
    }
}
