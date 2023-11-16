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

        public double Sconta3
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

        public string Memorizza3
        {

            get
            {
                double t = Sconta3;

                if (c == true)
                {
                    return codice + ";" + descrizione + ";" + t + ";" + tipo;
                }
                else
                {
                    return codice + ";" + descrizione + ";" + prezzo + ";" + tipo;
                }
            }
        }

    }
}
