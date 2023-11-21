using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    internal class ArticoloNonAlimentare : Articolo
    {
        private double prezzo3;
        private string materiale;

        public ArticoloNonAlimentare(int _codice, string _descrizione, double _prezzo, bool _card, string _tipo) : base(_codice, _descrizione, _prezzo, _card, _tipo)
        {
            this.prezzo3 = _prezzo;
            materiale = _descrizione;
        }

        public override double Sconta
        {
            get
            {
                if (materiale == "riciclabile")
                {
                    c = true;
                    return prezzo3 = prezzo3 - (prezzo3 / 100) * 10;
                }
                else
                {
                    return prezzo3;
                }
            }

        }

    }
}
