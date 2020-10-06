using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianStatickeVarijable2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa X = new PrvaKlasa("Pero","Perić");
            Console.WriteLine(X.ToString());
            PrvaKlasa Y = new PrvaKlasa("Ivica","Ivić");
            Console.WriteLine(Y.ToString());
            PrvaKlasa Z = new PrvaKlasa();
            

            Z.Ime = "Milorad";
            Z.Prezime = " Milić";
            Console.WriteLine(Z.ToString());








            Console.ReadKey();
            


        }
    }
}
