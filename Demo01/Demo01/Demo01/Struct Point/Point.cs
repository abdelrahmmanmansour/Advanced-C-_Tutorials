using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Struct_Point
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        override public string ToString()
        {
            return $"Point(X: {X}, Y: {Y})";
        }
        // Because Point implement IComparable
        // Without Defensive Code:
        //public int CompareTo(object? obj)
        //{
        //    Point p = (Point)obj;
        //    if (X == p.X)
        //    {
        //        return Y.CompareTo(p.Y);
        //    }
        //    else
        //    {
        //        return X.CompareTo(p.X);
        //    }
        //}

        // With Defensive Code: Avoid Null Reference Exception && anything other point
        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        if (obj is Point)
        //        {
        //           Point p = obj as Point;   // Return Null If Not Point
        //            if (X == p.X)
        //            {
        //                return Y.CompareTo(p.Y);
        //            }
        //            else
        //            {
        //                return X.CompareTo(p.X);
        //            }
        //        }
        //    }
        //    return 1; // Rerurn Caller
        //}

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if (X == other.X)
                {
                    return Y.CompareTo(other.Y);
                }
                else
                {
                    return X.CompareTo(other.X);
                }
            }
            return 1; // Return Caller
        }
    }
}
