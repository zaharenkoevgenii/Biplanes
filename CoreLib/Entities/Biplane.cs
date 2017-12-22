using System.Security.Cryptography.X509Certificates;
using CoreLib.Physics;
using CoreLib.Physics.Entities;

namespace CoreLib.Entities
{
    internal class Biplane : PhysicalObject,IBiplane
    {
        public double RPM { get; set; }

        internal override void InitializeForces()
        {
            Forces.Add(this.GetGravityForce());
            Forces.Add(this.GetAirResistanceForce());
            Forces.Add(this.GetTractionForce());
        }

        public override void Tick()
        {
            Location.X = Location.X + Speed.X + Acceleration.X/2;
            Location.Y = Location.Y + Speed.Y + Acceleration.Y / 2;
            Speed.X = Speed.X + Acceleration.X;
            Speed.Y = Speed.Y + Acceleration.Y;
            Acceleration.X = ResultantForce.X/Mass;
            Acceleration.Y = ResultantForce.Y/Mass;
        }
    }
}
