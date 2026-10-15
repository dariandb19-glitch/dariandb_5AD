using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DarianDB_
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
            int _getal;
            //Programma
            //Stap 1: intro
            Console.Write("Dag gebruiker we gaan beginnen met een eerste vraag: ");

            // Scherm leegmaken
            Console.Clear();

            //Stap 2: vraag getal + opslaan
            Console.Write("Geef me een eerste natuurlijke getal dat: ");
            _getal = int.Parse(Console.ReadLine());

            // Scherm leegmaken
            Console.Clear();

            //Stap 3: evalueer het getal 100 is
            if (_getal == 100)
            {
                Console.Write("U gaf een fout getal in.");

            }
            else if (_getal > 100)
            {
                Console.Write("Het getal dat u ingaf is groter dan 100");

            }
            else
            {
                Console.Write("Het getal dat u ingaf is kleiner dan 100.");

            }
        }
    }
}
