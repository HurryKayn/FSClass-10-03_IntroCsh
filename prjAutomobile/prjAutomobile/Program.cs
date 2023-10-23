using prjAutomobile.Auto;
using System.Xml.Linq;

namespace prjAutomobile
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Automobile auto1 = new Automobile();

            auto1.Modello = eModello.ferrari;

            Console.WriteLine("nome modello:" + auto1.Modello.ToString() + " numero modello: " + (int)auto1.Modello);
            auto1.LitriBenzinaInseriti = 20;
        }
    }
}