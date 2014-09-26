namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public static class Storage
    {
        public static void SavePointsToFile(string fileName, Path3D points)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLine(points);
            }
        }

        public static Path3D LoadPointsFromFile(string fileName)
        {
            Path3D points = new Path3D();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string text = reader.ReadToEnd();

                string pattern = "(\\-*\\d*\\.*\\d), (\\-*\\d*\\.*\\d), (\\-*\\d*\\.*\\d)";

                var reg = new Regex(pattern);
                var matches = reg.Matches(text);

                foreach (Match match in matches)
                {
                    double x = double.Parse(match.Groups[1].Value);
                    double y = double.Parse(match.Groups[2].Value);
                    double z = double.Parse(match.Groups[3].Value);

                    Point3D currentPoint = new Point3D(x, y, z);
                    points.AddPoints(currentPoint); 
                }
            }

            return points;
        } 
    }
}
