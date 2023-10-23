using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAutomobile.Auto
{
    public enum eModello
    {
        fiat,
        audi,
        mercedes,
        ferrari,
        lancia
    }

    internal class Automobile
    {
        private eModello modello;
        private int numeroCilindri = 4;
        public double litriBenzinaInseriti;

        public int NumeroPorte { get; } = 5;
        public int NumeroCilindri { get { return numeroCilindri; } }
        public int LitriBenzinaInseriti {
            set { litriBenzinaInseriti = value;
                Console.WriteLine("Rifornimento avvenuto con successo");
            } }
        internal eModello Modello {
            get { return modello; }
            set { modello = value;
            } 
        }
       
        public void printModello()
        {
          
            Console.WriteLine("nome modello:"+Modello.ToString()+" numero modello: " + (int)Modello);
  
        }
    }
}
