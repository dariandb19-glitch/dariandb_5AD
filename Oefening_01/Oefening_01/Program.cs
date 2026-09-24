using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Darian De Backer
             * 18/09/2026
             * Hallo Werled
            */

            //Velden

            //Programma
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Green;

            //Stap1: Toon de eerste spreuk
            Console.WriteLine("Met hard werken en streng zijn voor jezelf, kom je heel ver in het leven.\n");
            
            // Stap2: Vraag om op een toets te drukken
            Console.WriteLine("Druk op een toets om verder te gaan.\n");
            Console.ReadKey();

            // Scherm wissen
            Console.Clear();

            //Stap3: Toon de Tweede spreuk
            Console.WriteLine("Een diploma zorgt ervoor dat je aan een hoger loon start.\n");

            // Stap4: Vraag om op een toets te drukken
            Console.WriteLine("Druk op een toets om verder te gaan.\n");
            Console.ReadKey();

            // Scherm wissen
            Console.Clear();

            //Stap5: Toon de Derde spreuk
            Console.WriteLine("Programmeren is eerst analyseren in kleine stapjes\n");
            Console.ReadKey();

        }
    }
}
