using System.Collections.Generic;
using CoreLib.Physics.Entities;

namespace CoreLib.Physics.Interfaces
{
    interface IPhysicalObject
    {
        double Mass { get; set; }
        PhysicalPoint Location { get; set; }
        PhysicalVector Speed { get; set; }
        PhysicalVector Acceleration { get; set; }

        double Angle { get; set; }

        List<PhysicalVector> Forces { get; set; }
        PhysicalVector ResultantForce { get; }
    }
}
