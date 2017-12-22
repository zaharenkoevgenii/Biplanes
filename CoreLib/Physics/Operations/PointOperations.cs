using System.Linq;
using CoreLib.Physics.Entities;

namespace CoreLib.Physics.Operations
{
    internal static class PointOperations
    {
        internal static PhysicalPoint PointSum(params PhysicalPoint[] args)
        {
            var result = new PhysicalPoint();
            if (args.Length == 0) return result;
            result = args.Aggregate(result, Summ);
            return result;
        }

        private static PhysicalPoint Summ(PhysicalPoint vector1, PhysicalPoint vector2)
        {
            return new PhysicalPoint(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }

    }
}
