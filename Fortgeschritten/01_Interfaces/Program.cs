using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ITier[] tiersammlung = new ITier[3];
            tiersammlung[0] = new Löwe(10, "Weibchen");
            tiersammlung[1] = new Hund(8, "Männchen");
            tiersammlung[2] = new Hund(5, "Weibchen");

            foreach (var tier in tiersammlung)
            {
                if (tier is Löwe)
                {
                    Console.WriteLine("Der Löwe ist " + tier.Alter + " Jahre alt und ein " + tier.Geschlecht + ".");
                }
                else if (tier is Hund)
                {
                    Console.WriteLine("Der Hund ist " + tier.Alter + " Jahre alt und ein " + tier.Geschlecht + ".");
                }
            }
        }
    }
}