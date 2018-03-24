using System;

namespace Polymorphism
{
    class Healer : Unit
    {
        // Use the sealed keyword on overriden methods 
        // to prevent derived classes to override them again.
        public sealed override void UseAbility()
        {
            Console.WriteLine("Using healing ability");
        }
    }
}
