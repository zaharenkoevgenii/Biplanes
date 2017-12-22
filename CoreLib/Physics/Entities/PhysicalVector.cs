using System;

namespace CoreLib.Physics.Entities
{
    internal class PhysicalVector : PhysicalPoint
    {
        internal PhysicalVector()
            : base()
        {

        }

        internal PhysicalVector(double angle)
        {
            X = Math.Cos(angle);
            Y = Math.Sin(angle);
        }

        internal PhysicalVector(double x, double y)
            : base(x, y)
        {
        }

        internal PhysicalVector(PhysicalPoint point)
            : base(point.X, point.Y)
        {

        }

        internal double Value { get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); } }

        internal double Angle { get { return Math.Atan2(Y, X); } }


    }
}
