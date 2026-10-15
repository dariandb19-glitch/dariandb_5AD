using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Kleuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 * Darian De Backer
                 * 09/10/2026
                 * Project Geen Honderd
                */

            //Velden
            Byte _keuze = 0;

            //Programma
            //Stap 1: Toon de keuzes + opslaan
            Console.Write("Kies een kleur uit het menu: ");
            Console.WriteLine("  1. Rood \n  2. Groen \n  3. Blauw");

            //Stap 3: Toon het gekozen resultaat
            try
            {
                if (_keuze == 1)
                {
                    //Toon tekst
                    Console.WriteLine("U koos voor de kleur rood!");

                }
                else if (_keuze == 2)
                {
                    //Toon tekst
                    Console.WriteLine("U koos voor de kleur groen!");

                }
                else if (_keuze == 3)
                {
                    //Toon tekst
                    Console.WriteLine("U koos voor de kleur blauw!");

                }
                else
                {
                    //foutmelding
                    Console.WriteLine("U gaf geen geldige keuze in!");

                }
                Console.WriteLine("\nDruk op een toets om verder te gaan.....");
                Console.ReadKey();

            }
            catch
            {
                //Scherm leegmaken
                Console.Clear();

                //Foutmelding
                Console.WriteLine("U gaf geen juist getal in!");
                Console.WriteLine("\nDruk op een toets om verder te gaan...");
                Console.ReadKey();
            }
        }
    }
}
