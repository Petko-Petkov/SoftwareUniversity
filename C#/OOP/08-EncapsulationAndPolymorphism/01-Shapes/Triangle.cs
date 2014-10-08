namespace Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        #region Fields

        private double angle;

        #endregion

        #region Constructors

        public Triangle(double width, double height, double angle)
        {
            this.Width = width;
            this.Height = height;
            this.Angle = angle;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value for angle
        /// </summary>
        public double Angle
        {
            get
            {
                return this.angle;
            }

            set
            {
                if (value < 0 || value > 360)
                {
                    throw new ArgumentOutOfRangeException("Angle", "Enter value in the permited range - [0...360]");
                }

                this.angle = value;
            }
        }

        #endregion

        #region Methods

        public override double CalculateArea()
        {
            return (Math.Sin(this.Angle * Math.PI / 180) * this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height + Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) - 
                (2 * this.Height * this.Width * Math.Cos(this.Angle * Math.PI / 180))); 
        }

        #endregion
    }
}
