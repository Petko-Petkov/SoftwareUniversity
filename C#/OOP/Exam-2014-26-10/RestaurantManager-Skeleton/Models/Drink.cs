namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Drink : Recipe, IDrink
    {
        #region Construcotrs

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
            this.Time = timeToPrepare;
            this.Calories = calories;
        }

        #endregion

        #region Properties

        public bool IsCarbonated { get; private set; }

        public int Calories
        {
            get
            {
                return base.Calories;
            }

            private set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("Calories must NOT exceed 100", "Calories");
                }

                base.Calories = value;
            }
        }
        public int Time
        {
            get
            {
                return this.TimeToPrepare;
            }

            private set
            {
                if (value > 20)
                {
                    throw new ArgumentOutOfRangeException("Time must NOT exceed 20 minutes", "Minutes");
                }

                this.TimeToPrepare = value;
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            /*== <name> == $<price>
             Per serving: <quantity> <unit>, <calories> kcal
             Ready in <time_to_prepare> minutes
             Carbonated: <yes / no>
            */ 
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("== {0} == ${1}", this.Name, this.Price));
            result.AppendLine(string.Format("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, this.Unit, this.Calories));
            result.AppendLine(string.Format("Ready in {0} minutes", this.Time));
            result.AppendLine(string.Format("Carbonated: {0}", this.IsCarbonated ? "yes" : "no"));

            return result.ToString();
        }

        #endregion
    }
}
