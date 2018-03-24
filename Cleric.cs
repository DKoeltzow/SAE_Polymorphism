using System;

namespace Polymorphism
{
    class Cleric : Healer
    {
        // This class inherited UseAbility() from its base class
        // Overriding is not possible, because Healer sealed the method
    }
}