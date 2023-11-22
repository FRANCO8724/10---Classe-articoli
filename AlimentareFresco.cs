using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
        internal class AlimentareFresco : ArticoloAlimentare
        {

            private int _giorni;

        public int Giorni
        {
            get { return _giorni; }
            set { _giorni = value; }
        }

        public AlimentareFresco(int codice, string descrizione, double prezzo, bool card) : base(codice, descrizione, prezzo, card)
        {

            Random random = new Random();
            _giorni = random.Next(1, 6);

        }

            public override double Sconta()
            {
              double prezzoScontato = base.Sconta();

            return prezzoScontato = 2 * (6 - _giorni);
            }

        }
}
