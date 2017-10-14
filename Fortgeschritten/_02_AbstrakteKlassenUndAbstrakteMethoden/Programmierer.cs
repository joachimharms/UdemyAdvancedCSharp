using System;

namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    public class Programmierer : Arbeiter2
    {
        public override void ArbeitVerrichten2()
        {
            Console.WriteLine("Der Programmierer entwirft eine Software...");
        }
    }
}