using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaze_pojistencu
{
    class Pojistenec
    {
        /// <summary>
        /// Databáze s
        /// </summary>
        private Databaze databaze;

        /// <summary>
        /// Vytvoří novou instanci pojistence
        /// </summary>
        public Pojistenec()
        {
            databaze = new Databaze();
        }

        /// <summary>
        /// Vypíše všechny pojištěné 
        /// </summary>        
        public void VypisZaznamy()
        {
            List<Zaznam> zaznamy = databaze.VypisZaznamy();
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto pojištěnci: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné pojištěné.");
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vvyhleda pojištěnce podle jména a příjmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void VyhledatZaznamy()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;

            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }
            Console.WriteLine("Zadej příjmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }

            List<Zaznam> zaznamy = databaze.VyhledatZaznamy(jmeno, prijmeni);
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tito pojištěnci: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyli nalezeni žádní pojištěnci.");
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vyzve uživatele k přidání pojištěnce a uloží ho do databáze
        /// </summary>
        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;

            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine())) // kontrola mezer a prázdných znaků
            {
                Console.WriteLine("Zadej text znovu:");
            }
            Console.WriteLine("Zadej příjmení pojištěného:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej text znovu:");
            }
            Console.WriteLine("Zadej věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek)) //parsuje typ číslo
                Console.WriteLine("Chybné zadání, zadajte věk jako číslo: ");
            
            Console.WriteLine("Zadej telefon:");
            int telefon;
            while (!int.TryParse(Console.ReadLine(), out telefon))
                Console.WriteLine("Chybné zadání, zdajte telefonní číslo bez mezer: ");
            
            databaze.PridejZaznam(jmeno, prijmeni, vek, telefon);

            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
        }       
 
        /// <summary>
        /// Vypíše úvodní obrazovku programu
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Evidence pojistenych");
            Console.WriteLine("--------------------");            
        }

    }
}

