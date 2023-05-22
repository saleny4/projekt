using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaze_pojistencu
{
    /// <summary>
    /// Záznam v pojistenci
    /// </summary>
    class Zaznam
    {
        /// <summary>
        /// Jméno
        /// </summary>
        public string jmeno { get; set; }
        /// <summary>
        /// Příjmení
        /// </summary>
        public string prijmeni { get; set; }

        public int vek { get; set; }
        public int telefon { get; set; }

        /// <summary>
        /// Vytvoří novou instanci pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefon"></param>
        public Zaznam(string jmeno, string prijmeni, int vek, int telefon)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.telefon = telefon;
        }

        /// <summary>
        /// Vrátí textovou reprezentaci pojištěnce
        /// </summary>
        /// <returns>Textová reprezentace pojištěnce</returns>
        public override string ToString()
        {
            return jmeno + " " + prijmeni + " " + vek.ToString() + " " + telefon.ToString();
        }
    }
}
