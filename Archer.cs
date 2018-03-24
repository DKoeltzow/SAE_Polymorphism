using System;

namespace Polymorphism
{
    class Archer : Unit
    {
        // Override a virtual method to provide class specific implementation.
        public override void UseAbility()
        {
            Console.WriteLine("Shooting an arrow");
        }
    }
}
