using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLectureAsynchronousProgramming
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double GetDistanceFrom(Point p)
        {
            double dx, dy;
            dx = p.X - X;
            dy = p.Y - Y;
            //faster than using Math.Pow
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
