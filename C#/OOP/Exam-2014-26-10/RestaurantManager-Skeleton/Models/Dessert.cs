namespace RestaurantManager.Models
{
    using System;
    using System.Globalization;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Dessert : Meal, IDessert
    {
        #region Fields

        private bool withSugar;

        #endregion

        #region Constructors

        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.WithSugar = true;
        }
        public bool WithSugar
        {
            get
            {
                return this.withSugar;
            }

            private set
            {
                this.withSugar = value;
            }
        }
        #endregion

        #region Methods

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            /*
             * <[NO SUGAR] ><[VEGAN] >== <name> == $<price>
               Per serving: <quantity> <unit>, <calories> kcal
               Ready in <time_to_prepare> minutes

             */

            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine(string.Format("{0}{1}== {2} == ${3}", 
                this.WithSugar ? string.Empty : "[NO SUGAR] ",
                this.IsVegan ? "[VEGAN] " : string.Empty,
                this.Name,
                this.Price
                ));

            return result.ToString();
        }

        #endregion
    }
}
