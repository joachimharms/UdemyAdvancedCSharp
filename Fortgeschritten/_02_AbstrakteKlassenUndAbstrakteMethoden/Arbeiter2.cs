using System;

namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    public abstract class Arbeiter2
    {
        // Eigenschaften
        public double Gehalt { get; set; }

        public string Name { get; set; }

        // virtuelle Methode:
        public virtual void ArbeitVerrichten2()
        {
            Console.WriteLine("Der Arbeiter verrichtet seine Arbeit...");
        }
    }
}