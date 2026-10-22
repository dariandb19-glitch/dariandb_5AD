using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_keuzemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Darian De Backer
            //project keuzemenu
            //22-10-2026

            //velden
            byte _keuze = 0;

            //programma
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                //scherm wissen
                Console.Clear();

                //Stap1: toon de gebruiker een menu van 3 keuzes en afsluiten
                Console.WriteLine("maak uw keuze uit onderstaande menu");
                Console.WriteLine("\n   1) Keuze1  \n  2) keuze2  \n   3) keuze3  \n   4) afsluiten");

                try
                {
                    //Stap2: vraag de keuze + opslaan
                    Console.Write("\nUw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());
                    //Stap3: toon de juiste tekst afhankelijk van de keuze
                    // als 1
                    if (_keuze == 1)
                    {
                        // toon de tekst
                        Console.WriteLine("U koos keuze 1!");
                    }
                    // als 2
                    else if (_keuze == 2)
                    {
                        // toon de tekst
                        Console.WriteLine("U koos keuze 2!");
                    }
                    // als 3
                    else if (_keuze == 3)
                    {
                        // toon de tekst
                        Console.WriteLine("U koos keuze 3!");
                    }
                    // als 4
                    else if (_keuze == 4)
                    {
                        // toon de tekst
                        Console.WriteLine("Tot de volgende keer!");
                    }
                    // als het iets anders is
                    else
                    {
                        Console.WriteLine("U gaf een fout getal in buddy!");

                    }


                }
                catch
                {
                    // schermwissen
                    Console.Clear();
                    // foutmelding
                    Console.WriteLine("u gaf geen getal in buddy");
                    Console.WriteLine("\n druk op enter om verder te gaan");
                    Console.ReadLine();
                }
                //Stap4: als keuze niet 4 is, ga naar stap 1
            } while (_keuze != 4);

        }
    }
}
