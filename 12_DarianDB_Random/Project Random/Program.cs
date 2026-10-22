using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Darian De Backer
            //Project Random
            //16-10-2026

            // Velden
            Byte _keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _getal1 = -1;
            int _getal2 = -1;
            // Programma
            do
            {
                // Schermwissen
                Console.Clear();

                // STAP 1: Toon het keuzemenu
                Console.WriteLine("1. Maak 2 randoms zonder voorwaarde");
                Console.WriteLine("2. Maak 2 verschillende willekeurige getallen ");
                Console.WriteLine("3. Maak 2 verschillende willekeurige getallen met max waarde");
                Console.WriteLine("4. Maak 2 verschillende willekeurige getallen met min en max waarde");
                Console.WriteLine("5. Afsluiten");
                try
                {
                    // Vraag de keuze + opslaan
                    Console.Write("Geef uw keuze. ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // als 1:
                    if (_keuze == 1)
                    {
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        // Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn: {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan");
                        Console.ReadKey();
                    }
                    // als 2:
                    else if (_keuze == 2)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm1.Next();

                        // Toon ze Op het scherm
                        Console.WriteLine($"De twee getallen zijn: {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan");
                        Console.ReadKey();

                    }
                    // als 3:
                    else if (_keuze == 3)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next(10);
                        _getal2 = _rdm1.Next(10);

                        // Toon ze Op het scherm
                        Console.WriteLine($"De twee getallen zijn: {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan");
                        Console.ReadKey();

                    }
                    // als 4:
                    else if (_keuze == 4)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next(10, 100);
                        _getal2 = _rdm1.Next(10, 100);

                        // Toon ze Op het scherm
                        Console.WriteLine($"De twee getallen zijn: {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan");
                        Console.ReadKey();

                    }
                    // als 5:
                    else if (_keuze == 5)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm1.Next();

                        // Toon ze Op het scherm
                        Console.WriteLine($"Tot een volgende keer!");
                        Console.WriteLine("Druk op enter om verder te gaan");
                        Console.ReadKey();

                    }
                    else
                    {
                        // Foutmelding
                        Console.WriteLine("U gaf geen geldig getal in. ");
                        Console.WriteLine("Druk op enter om terug te keren naar het keuzemenu. ");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    // Schermwissen

                    //foutmelding
                    Console.WriteLine("U gaf geen getal in!");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het keuzemenu!");
                    Console.ReadKey();
                }
            }
            while (_keuze != 5);
        }
    }
}
