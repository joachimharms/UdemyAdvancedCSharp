using System;

namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hendrick = new Handwerker();
            hendrick.ArbeitVerrichten();
            hendrick.Gehalt = 2000.00;
            hendrick.Name = "Hendrick Müller";

            var susi = new Elektriker();
            susi.ArbeitVerrichten();
            susi.Gehalt = 1900;
            susi.Name = "Susi Sorglos";

            Console.ReadKey();
        }
    }
}