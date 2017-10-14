using System;

namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    public class Handwerker : Arbeiter
    {
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Handwerker repariert das Auto...");
        }
    }
}