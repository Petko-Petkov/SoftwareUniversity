namespace Shapes
{
    public class Rectangle : BasicShape
    {
        #region Constructors

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        #endregion

        #region Methods

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width + this.Height) * 2;
        }

        #endregion
    }
}
