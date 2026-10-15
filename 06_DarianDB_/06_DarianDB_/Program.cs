using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _06_DarianDB_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * Darian De Backer
                * 01/10/2026
                * Project Getallen
               */

            //Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _getal3 = 0;

            //Programma
            try
            {
                //Stap 1: Vraag een eerste getal +opslaan
                Console.Write("Geef me een eerste getal tussen de 0 en 100: ");
                _getal1 = int.Parse(Console.ReadLine());

                // Scherm leegmaken
                Console.Clear();

                //Stap 2: Vraag een tweede getal +opslaan
                Console.Write("Geef me een tweede getal tussen de 0 en 100: ");
                _getal2 = int.Parse(Console.ReadLine());

                // Scherm leegmaken
                Console.Clear();

                //Stap 3: Vraag een derde getal +opslaan
                Console.Write("Geef me een derde getal tussen de 0 en 100: ");
                _getal3 = int.Parse(Console.ReadLine());

                // Scherm leegmaken
                Console.Clear();

                //Stap 4: Toon de juiste tekst
                Console.WriteLine($"Het derde getal dat je ingaf: {_getal3.ToString()}");
                Console.WriteLine($"Het tweede getal dat je ingaf: {_getal2.ToString()}");
                Console.WriteLine($"Het eerste getal dat je ingaf: {_getal1.ToString()}");
            }
            catch
            {
                // Scherm leegmaken
                Console.Clear();

                // foutmelding
                Console.WriteLine("U gaf geen getal in.");
                Console.WriteLine("\nDruk op enter om af te sluiten.");
            }

         }
    }
}
