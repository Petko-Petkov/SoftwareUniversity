namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Salad : Meal, ISalad
    {
        #region Fields

        private bool containsPasta;

        #endregion

        #region Constructors

        public Salad(
            string name,
            decimal price,
            int calories,
            int quantityPerServing,
            int timeToPrepare,
            bool containsPast)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.ContainsPasta = containsPast;
            this.IsVegan = true;
        }

        #endregion

        #region Properties

        public bool ContainsPasta { get; private set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine(string.Format("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no"));

            return result.ToString();
        }

        #endregion
    }
}
