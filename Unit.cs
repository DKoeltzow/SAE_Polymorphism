using System;

namespace Polymorphism
{
    public abstract class Unit
    {
        // Make a method virtual to enable derived classes to override it so that
        // they can provide their own implementation.
        public virtual void UseAbility()
        {
            Console.WriteLine("Using base ability");
        }
    }
}
