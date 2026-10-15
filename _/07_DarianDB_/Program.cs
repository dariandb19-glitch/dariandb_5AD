using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DarianDB_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Darian De Backer
             * 02/10/2026
             * Project Rekensom
             */

            //Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _opsomming = 0;
            int _vermeerderd = 0;
            int _vermenigvuldiging = 0;
            int _deling = 0;

            //Programma
            try
            {
                //Stap 1: Vraag een eerste getal +opslaan
                Console.Write("Geef me een eerste natuurlijke getal: ");
                _getal1 = int.Parse(Console.ReadLine());

                // Scherm leegmaken
                Console.Clear();

                try
                {

                    //Stap 2: Vraag een tweede getal +opslaan
                    Console.Write("Geef me een tweede natuurlijke getal: ");
                    _getal2 = int.Parse(Console.ReadLine());

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 3: Voer de opsomming uit +opslaan
                    _opsomming = _getal1 + _getal2;

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 4: Voer de opsomming uit +opslaan
                    _vermeerderd = _opsomming + 5;

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 5: Voer de vermenigvuldiging uit +opslaan
                    _vermenigvuldiging = _vermeerderd * 10;

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 6: Voer de deling uit + opslaan
                    _deling = _vermenigvuldiging / 2;

                    // Scherm leegmaken
                    Console.Clear();

                    //Stap 7: Geef het uiteindelijke resultaat weer.
                    Console.WriteLine($"U gaf het getal {_getal1.ToString()} en het getal {_getal2.ToString()} in.");
                    Console.WriteLine($"De som hiervan is {_opsomming.ToString()}");
                    Console.WriteLine($"Dit getal werd vermeerder met 5. Dit gaf als uitkomst  {_vermeerderd.ToString()}");
                    Console.WriteLine($"Daarna werd er vermenigvuldig met 10. Dit gaf als uitkomst {_vermenigvuldiging.ToString()}");
                    Console.WriteLine($"Als laatste werd er gedeeld door 2.");
                    Console.WriteLine($"Het uiteindelijke resultaat is {_deling.ToString()}");
                }
                catch
                {
                    // Scherm leegmaken
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("Het tweede getal was fout.");
                    Console.WriteLine("\nDruk op enter om af te sluiten.");
                }
            } 
            catch
            {
                // Scherm leegmaken
                Console.Clear();

                // foutmelding
                Console.WriteLine("Het eerste getal was fout.");
                Console.WriteLine("\nDruk op enter om af te sluiten.");
            }
        }
    }
}
