using System;

namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    public class Elektriker : Arbeiter
    {
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Elektriker öffnet den Stromkasten...");
        }
    }
}