using System.CodeDom;
using System.Linq;
using CoreLib.Physics.Entities;

namespace CoreLib.Physics.Operations
{
    internal static class VectorOperations
    {
        internal static PhysicalVector VectorSum(params PhysicalVector[] args)
        {
            var result = new PhysicalVector();
            if (args.Length == 0) return result;
            result = args.Aggregate(result, Summ);
            return result;
        }

        private static PhysicalVector Summ(PhysicalVector vector1, PhysicalVector vector2)
        {
            return new PhysicalVector( PointOperations.PointSum(vector1,vector2));
        }

        internal static PhysicalVector VectorDirection(this PhysicalVector vector1)
        {
            return new PhysicalVector(vector1.X / vector1.Value, vector1.Y / vector1.Value);
        }

        internal static PhysicalVector VectorMultiply(this PhysicalVector vector1, double multiplicator)
        {
            return new PhysicalVector(vector1.X / multiplicator, vector1.Y / multiplicator);
        }
    }
}
