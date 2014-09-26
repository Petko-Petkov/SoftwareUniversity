namespace Point3D
{
    using System;
    using System.Text;

    public class Point3D
    {
        private static readonly Point3D startingPoint;
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public double ZPosition { get; set; }

        static Point3D()
        {
            startingPoint = new Point3D(0, 0, 0);
        }
        public Point3D(double x, double y, double z)
        {
            this.XPosition = x;
            this.YPosition = y;
            this.ZPosition = z;
        }

        public static Point3D StartingPoint 
        {
            get { return Point3D.startingPoint; }
        }

        public override string ToString()
        {
            return "(" + this.XPosition + ", " + this.YPosition + ", " + this.ZPosition + ")";
        }
    }
}
