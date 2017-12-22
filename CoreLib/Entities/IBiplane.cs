using CoreLib.Physics.Interfaces;

namespace CoreLib.Entities
{
    interface IBiplane:IPhysicalObject
    {
        double RPM { get; set; }
    }
}
