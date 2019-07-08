using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            // put your code here
            // throw new NotImplementedException();
            if (points == null)
                throw new ArgumentNullException();
            if (range <= 0)
                throw new ArgumentException();

            List<Point> result = new List<Point>();

            foreach (var item in points)
            {
                if ((Math.Abs(item.X - point.X) <= range) && (Math.Abs(item.Y - point.Y) <= range))
                    result.Add(item);
            }

            return result;
        }
    }
}