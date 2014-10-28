namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class MainCourse : Meal, IMainCourse
    {
        #region Constructors

        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Type = (MainCourseType)Enum.Parse(typeof(MainCourseType), type, true);
        }

        #endregion

        #region Properties

        public MainCourseType Type { get; private set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine(string.Format("Type: {0}", this.GetType().Name));

            return result.ToString();
        }

        #endregion
    }
}
