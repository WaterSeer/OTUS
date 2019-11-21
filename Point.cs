using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public  class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public override string ToString()
        {
            return $"[{X},{Y}]";
        }

        //перегруженная операция  +
        public static Point operator +(Point p1, Point p2) =>
            new Point(p1.X + p2.X, p1.Y + p2.Y);

        //перегруженная операция  -
        public static Point operator -(Point p1, Point p2) =>
            new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
}
