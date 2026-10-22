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

            //velden
            byte _keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _getal1 = -1;
            int _getal2 = -1;
            //programma
            do
            {
                Console.Clear();

                //toon keuzemenu
                Console.WriteLine("maak uw keuze uit onderstaande menu");
                Console.WriteLine("   1) maak 2 randoms zonder voorwaarde");
                Console.WriteLine("   2) Afsluiten");

                try
                {
                    // vraag de keuze + opslaan
                    Console.Write("\ngeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    if (_keuze == 1)
                    {
                        //maak 2 will getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        //toon ze op het scherm
                        Console.WriteLine($"de twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.Write("\n druk om trg nr de menu te gaan");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (_keuze == 2)
                    {
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        //toon ze op het scherm
                        Console.WriteLine($"de twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.Write("\n druk om trg nr de menu te gaan");
                        Console.ReadKey();
                    }
                    else if (_keuze == 3)
                    {
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        //toon ze op het scherm
                        Console.WriteLine($"de twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.Write("\n druk om trg nr de menu te gaan");
                        Console.ReadKey();
                    }
                    else if (_keuze == 4)
                    {
                        //toon afsluittekst
                        Console.WriteLine("tot de volgende keer");
                        Console.Write("\n druk om trg nr de menu te gaan");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"U gaf geen geldige keuze in");
                        Console.WriteLine("druk op enter om verder te gaan");

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.Clear();
                }


            } while (_keuze != 2);
        }
    }
}
