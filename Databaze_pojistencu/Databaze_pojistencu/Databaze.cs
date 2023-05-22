using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaze_pojistencu
{
    /// <summary>
    /// Třída spravuje kolekci pojištěnců
    /// </summary>
    class Databaze
    {
        /// <summary>
        /// Kolekce pojištěnců
        /// </summary>
        private List<Zaznam> zaznamy;

        /// <summary>
        /// Vytvoří novou instanci databáze
        /// </summary>
        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        /// <summary>
        /// Přidá nového pojištěnce do databáze
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <param name="vek">Věk</param>
        /// <param name="telefon">Telefon</param>
        public void PridejZaznam(string jmeno, string prijmeni, int vek, int telefon)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, vek, telefon));
        }

        /// <summary>
        /// Vypíše všechny pojištěnce
        /// </summary>
        public List<Zaznam> VypisZaznamy()
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                nalezene.Add(z);
            }
            return nalezene;
        }
        /// <summary>
        /// Vyhleda pojistence
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public List<Zaznam> VyhledatZaznamy(string jmeno, string prijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
             if ((z.jmeno == jmeno) && (z.prijmeni == prijmeni)) // dle jmena a prijmeni
                nalezene.Add(z);
            }
            return nalezene;
        }

    }
}
