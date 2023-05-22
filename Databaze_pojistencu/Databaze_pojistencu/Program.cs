using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Databaze_pojistencu
{
    class Program
    {
            // instance pojistěnce
            static void Main(string[] args)
            {
                // instance pojištěnce
                Pojistenec pojistenec = new Pojistenec();
                char volba = '0';
                // hlavní cyklus
                while (volba != '4')
                {
                    pojistenec.VypisUvodniObrazovku();
                    Console.WriteLine();
                    Console.WriteLine("Vyberte si akci:");
                    Console.WriteLine("1 - Přidat nového pojištěného");
                    Console.WriteLine("2 - Vypsat všechny pojištěné");
                    Console.WriteLine("3 - Vyhledat pojištěného");
                    Console.WriteLine("4 - Konec");
                    volba = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    // reakce na volbu
                    switch (volba)
                    {
                        case '1':
                            pojistenec.PridejZaznam();
                            break;
                        case '2':
                            pojistenec.VypisZaznamy();
                            break;
                        case '3':
                            pojistenec.VyhledatZaznamy();
                            break;
                        case '4':
                            Console.WriteLine("Libovolnou klávesou ukončíte program...");
                            break;
                        default:
                            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                            break;
                    }
                    Console.ReadKey();
                }
            }
    }
}
