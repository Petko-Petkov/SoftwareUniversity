namespace Point3D
{
    using System;

    class Point3DMain
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(3, -5, 3.5);
            Point3D secondPoint = new Point3D(-5, 9, 8.9);

            Console.WriteLine("First point: {0}", firstPoint);
            Console.WriteLine("Second point: {0}", secondPoint);

            Console.WriteLine("Distance between first and second point is " + DistanceCalculator.CalculateDistance(firstPoint, secondPoint));

            Path3D path = new Path3D(firstPoint, secondPoint);

            Storage.SavePointsToFile("output.txt", path);
            
            Path3D loadedFromFile = Storage.LoadPointsFromFile("output.txt");
            Console.WriteLine("Points loaded from file are : {0}", loadedFromFile);
        }
    }
}
