using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    class Articolo
    {
        protected int _codice;
        protected string _descrizione;
        protected double _prezzo;
        protected bool card;

        static int codice
        {
            get { return codice; }
            set { codice = value; }
        }
        static int descrizione
        {
            get { return descrizione; }
            set { descrizione = value; }
        }
        static int prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }

        public Articolo(int codice, string descrizione, double prezzo, bool _card)
        {
            this._codice = codice;
            this._descrizione = descrizione;
            this._prezzo = prezzo;
            this.card = _card;
        }

        public virtual double Sconta
        {
            get
            {
                if (card == true)
                {
                    return prezzo = prezzo - (prezzo / 100) * 5;
                }
                else
                {
                    return prezzo;
                }
            }

        }


    }
}
    

