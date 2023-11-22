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

        public int Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public Articolo(int codice, string descrizione, double prezzo, bool _card)
        {
            this._codice = codice;
            this._descrizione = descrizione;
            this._prezzo = prezzo;
            this.card = _card;
        }

        public virtual double Sconta()
        { 
                if (card)
                {
                    return Prezzo =   Prezzo - (Prezzo / 100) * 5;
                }
                else
                {
                    return Prezzo;
                }
        }

    }


}

    

