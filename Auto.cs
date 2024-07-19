using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial
{
    internal class Auto
    {
        // Felder
        public string farbe;    // Achtung - nur zu Demonstrationszwecken!
        public int hoechstGeschwindigkeit;    // Achtung - nur zu Demonstrationszwecken!


        // Methoden
        // Gibt die Farbe, die Höchstgeschwindigkeit und eine Text auf der Konsole aus.
        public void Fahren()
        {
            Console.WriteLine($"Das Auto hat die Farbe {farbe}");
            Console.WriteLine($"Das Auto hat die Höchstgeschwindigkeit {hoechstGeschwindigkeit}");
            Console.WriteLine($"Das Auto fährt...");
        }
    }
}
