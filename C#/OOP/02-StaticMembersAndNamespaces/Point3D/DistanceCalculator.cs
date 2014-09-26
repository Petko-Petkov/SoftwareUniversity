using System;
namespace Point3D
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = firstPoint.XPosition - secondPoint.XPosition;
            double deltaY = firstPoint.YPosition - secondPoint.YPosition;
            double deltaZ = firstPoint.ZPosition - secondPoint.ZPosition;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}
