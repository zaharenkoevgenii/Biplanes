using System;
using CoreLib.Entities;
using CoreLib.Physics.Entities;
using CoreLib.Physics.Interfaces;
using CoreLib.Physics.Operations;

namespace CoreLib.Physics
{
    internal static class ForcesFactory
    {
        internal static PhysicalVector GetGravityForce(this IPhysicalObject obj)
        {
            return new PhysicalVector(0,obj.Mass*PhysicalConstants.GravityAcceleration);
        }

        internal static PhysicalVector GetTractionForce(this IBiplane obj)
        {
            return new PhysicalVector(obj.Angle+PhysicalConstants.AngleStep).VectorMultiply(obj.RPM*BiplaneConstants.RPMtoTractionKoefficient);
        }

        internal static PhysicalVector GetAirResistanceForce(this IPhysicalObject obj)
        {
            return new PhysicalVector(obj.Speed.Angle + Math.PI).VectorMultiply(obj.Speed.Value * PhysicalConstants.AirResistanceKoefficient);
        }
    }
}
