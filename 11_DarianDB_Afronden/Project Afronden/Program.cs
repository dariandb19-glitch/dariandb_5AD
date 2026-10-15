using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_Afronden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Darian De Backer
             * 13/10/2026
             * Project Afronden
             */

            //Velden
            float _floatvar = 0f;
            Double _doublevar = 0;
            Decimal _decimalvar = 0M;
            //Programma
            //Stap 1: Bereken 0,1 + 0,2 in de 3 typen van variabelen
            _floatvar = 0.1f + 0.2f;
            _doublevar = 0.1 + 0.2;
            _decimalvar = 0.1m + 0.2m;

            //Stap 2: Toon de resultaten
            Console.WriteLine($"float: {_floatvar}");
            Console.WriteLine($"double: {_doublevar}");
            Console.WriteLine($"decimal: {_decimalvar}");

            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            //Scherm wissen
            Console.Clear();

            //Stap 3: ga na of float exact 0,3 weergeeft
            if (_floatvar == 0.3)
            {
                //•	Als ja
                //       Stap 4: Toon exact “0,3”
                    Console.WriteLine("Float is exact 0.3");
            }
            //•	Als nee
            else
            {
                //       Stap 5: Toon “niet 0,3”
                Console.WriteLine("Float is niet 0.3");
            }
            //Stap 6: ga na of double exact 0,3 weergeeft
            if (_doublevar == 0.3) 
            {
                //•	Als ja
                //       Stap 7: Toon exact “0,3”
                Console.WriteLine("Double is exact 0.3");
            }
                //•	Als nee
            else
            {
                //       Stap 8: Toon “niet 0,3”
                Console.WriteLine("Double is niet 0.3");
            }
            //Stap 9: ga na of decimal exact 0,3 weergeeft
            if (_decimalvar == 0.3M)
            {
                //•	Als ja
                //       Stap 10: Toon exact “0,3”
                Console.WriteLine("Decimal is exact 0.3");
            }
                //•	Als nee
            else
            {
                //       Stap 11: Toon “niet 0,3”
                Console.WriteLine("Decimal is niet 0.3");
            }
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();
        }
    }
}
