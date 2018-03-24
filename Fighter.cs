using System;

namespace Polymorphism
{
    class Fighter : Unit
    {
        // Use new keyword to hide method from derived ones.
        // This breaks the connection between inheritance or polymorphism.
        public new void UseAbility()
        {
            Console.WriteLine("I do what i want");

        }
    }
}
