using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    internal class ArticoloNonAlimentare : Articolo
    {

        public ArticoloNonAlimentare(int codice, string descrizione, double prezzo, bool card) : base(codice, descrizione, prezzo, card)
        {
            
        }

        public override double Sconta()
        {

            double prezzoScontato = base.Sconta();

            return prezzoScontato = prezzoScontato - (prezzoScontato / 100) * 10;
           
        }

    }
}
