using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dariandb_5AD_project_favoriet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Darian De Backer
             * 29/09/2026
             * Project favoriet
            */

            //Velden
            String _kleurGebruiker = null;
            String _favorietedagGebruiker = null;
            String _favorieteseizoenGebruiker = null;
            String _zin = null;


            //Programma
            //Stap1: Vraag de kleur +opslaan
            Console.Write("Kies een kleur: ");
            _kleurGebruiker = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap2: Maak de juiste tekst
            _zin = $"Je koos {_kleurGebruiker} ";

            //Stap3: Toon de tekst in de juiste vorm
            Console.WriteLine(_zin);
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            //Stap4: Vraag de favoriete dag +opslaan
            Console.Write("Geef je favoriete weekdag: ");
            _favorietedagGebruiker = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap5: Maak de juiste tekst
            _zin = $"Je favoriete dag is: {_favorietedagGebruiker} ";

            //Stap6: Toon de tekst in de juiste vorm
            Console.WriteLine(_zin);
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();

            //Stap7: Vraag het favoriete seizoen +opslaan
            Console.Write("Geef je favoriete seizoen: ");
            _favorieteseizoenGebruiker = Console.ReadLine();

            //Scherm wissen
            Console.Clear();

            //Stap8: Maak de juiste tekst
            _zin = $"Je favoriete seizoen is: {_favorieteseizoenGebruiker} ";

            //Stap9: Toon de tekst in de juiste vorm
            Console.WriteLine(_zin);
            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();
        }
    }
}
