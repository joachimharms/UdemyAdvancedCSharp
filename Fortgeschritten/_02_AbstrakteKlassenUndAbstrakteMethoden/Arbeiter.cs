namespace _02_AbstrakteKlassenUndAbstrakteMethoden
{
    public abstract class Arbeiter
    {
        // mit dem keyword abstract sagen wir dass die Klasse und die abstract Methoden nicht instanziiert werden können.
        // Eigenschaften
        public double Gehalt { get; set; }

        public string Name { get; set; }

        // abstrakte Methoden
        public abstract void ArbeitVerrichten();
    }
}