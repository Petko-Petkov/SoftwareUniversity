namespace Shapes
{
    using System;

    public class Circle : IShape
    {
        #region Fields

        private double radius;

        #endregion

        #region Constructors

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        #endregion

        #region Properties

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius", "Value for radius must be positive");
                }

                this.radius = value;
            }
        }

        #endregion

        #region Methods

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        #endregion
    }
}
