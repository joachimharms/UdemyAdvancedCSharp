using System;

namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // abstrakte überschriebene Methode:
            var hendrick = new Handwerker();
            hendrick.ArbeitVerrichten();
            hendrick.Gehalt = 2000.00;
            hendrick.Name = "Hendrick Müller";

            // abstrakte überschriebene Methode:
            var susi = new Elektriker();
            susi.ArbeitVerrichten();
            susi.Gehalt = 1900;
            susi.Name = "Susi Sorglos";

            // Aufruf virtuelle geerbte Methode:
            var heini = new Mechatroniker();
            heini.ArbeitVerrichten2();
            heini.Gehalt = 3500.00;
            heini.Name = "Heinz Bauer";

            // Aufruf virtuelle überschriebene Methode:
            var joachim = new Programmierer();
            joachim.ArbeitVerrichten2();
            joachim.Gehalt = 10000.00;
            joachim.Name = "Joachim H.";

            Console.ReadKey();
        }
    }
}