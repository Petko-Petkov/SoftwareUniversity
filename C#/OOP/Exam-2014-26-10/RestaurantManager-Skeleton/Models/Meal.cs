namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public abstract class Meal : Recipe, IMeal
    {
        #region Constructors

        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            
        }

        #endregion

        #region Proeprties

        public bool IsVegan { get; protected set; }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            /*
             <[VEGAN] >== <name> == $<price>
             Per serving: <quantity> <unit>, <calories> kcal
             Ready in <time_to_prepare> minutes

             */

            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0}== {1} == ${2}", IsVegan? "[VEGAN] " : string.Empty, this.Name, this.Price));
            result.AppendLine(string.Format("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, this.Unit, this.Calories));
            result.AppendLine(string.Format("Ready in {0} minutes", this.TimeToPrepare));

            return result.ToString();
        }

        #endregion
    }
}
