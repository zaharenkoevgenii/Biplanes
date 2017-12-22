namespace CoreLib.Physics.Entities
{
    internal class PhysicalPoint
    {
        public PhysicalPoint()
        {
            X = 0;
            Y = 0;
        }

        public PhysicalPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        internal double X { get; set; }
        internal double Y { get; set; }
    }
}
