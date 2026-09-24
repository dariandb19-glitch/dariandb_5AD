using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Darian De Backer
             * 22/09/2026
             * Project Hallo Naam
            */

            //Velden
            String _naamGebruiker = null;
            String _bewerking = null;

            //Programma
            //Stap1: Vraag naam +opslaan
            Console.Write("Geef uw naam: ");
            _naamGebruiker = Console.ReadLine();

            //Stap2: Maak de juiste tekst
            //_bewerking = "Hallo" + _naamGebruiker;
            //_bewerking = String.Format("hallo {0}" + _naamGebruiker);
            _bewerking = $"Hallo {_naamGebruiker}";

            //Scherm wissen
            Console.Clear();

            //Stap3: Toon de tekst in de juiste vorm
            Console.WriteLine(_bewerking);



        }
    }
}
