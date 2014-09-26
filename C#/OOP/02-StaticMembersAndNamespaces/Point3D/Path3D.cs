namespace Point3D
{
    using System;
    using System.Collections.Generic;

    public class Path3D
    {
        private List<Point3D> points = new List<Point3D>();

        public Path3D(params Point3D[] points)
        {
            if (points.Length > 0)
            {
                this.points.AddRange(points);
            }
        }

        public void AddPoints(Point3D point)
        {
            this.points.Add(point);
        }

        public override string ToString()
        {
            return string.Join(", ", this.points);
        }
    }
}
