using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            units.Add(new Archer());
            units.Add(new Fighter());
            units.Add(new Healer());
            units.Add(new Cleric());
           
            

            // Look at the differences between declared types and runtime types
            foreach (Unit unit in units)
            {
                unit.UseAbility();
            }

            Console.Read();
        }
    }
}
