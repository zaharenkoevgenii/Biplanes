using System.Collections.Generic;
using CoreLib.Physics.Interfaces;
using CoreLib.Physics.Operations;

namespace CoreLib.Physics.Entities
{
    internal abstract class PhysicalObject:IPhysicalObject
    {
        internal PhysicalObject()
        {
            Forces = new List<PhysicalVector>();
            Location = new PhysicalPoint();
            Speed = new PhysicalVector();
            Acceleration = new PhysicalVector();
            InitializeForces();
        }

        public double Mass { get; set; }

        public PhysicalPoint Location { get; set; }
        public PhysicalVector Speed { get; set; }
        public PhysicalVector Acceleration { get; set; }

        public double Angle { get; set; }

        public List<PhysicalVector> Forces { get; set; }

        internal abstract void InitializeForces();

        public PhysicalVector ResultantForce
        {
            get { return VectorOperations.VectorSum(Forces.ToArray()); }
        }

        public abstract void Tick();
    }
}
