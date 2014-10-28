namespace RestaurantManager.Models
{
    using System;

    using RestaurantManager.Interfaces;

    public abstract class Recipe : IRecipe
    {
        #region Fields

        private string name;

        private decimal price;

        private int calories;

        private int quantityPerServing;

        private int timeToPrepare;

        #endregion

        #region Constructors

        public Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name is required.", this.name);
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be positive", "Price");
                }

                this.price = value;
            }
        }

        public int Calories
        {
            get { return this.calories; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The calories must be positive.", "Calories");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity cannot be negative.", "Quantity");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; protected set; }

        public int TimeToPrepare
        {
            get { return this.timeToPrepare; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The time must be positive", "Time");
                }

                this.timeToPrepare = value;
            }
        }

        #endregion
    }
}
