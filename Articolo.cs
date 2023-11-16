using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    internal class Articolo
    {
        protected int codice;
        protected string descrizione;
        protected double prezzo;
        protected bool card;
        string[] Scontrino = new string[100];
        int cont;

        public Articolo(int _codice, string _descrizione, double _prezzo, bool _card, string[] Scontrino,int cont)
        {
            this.codice = _codice;
            this.descrizione = _descrizione;
            this.prezzo = _prezzo;
            this.card = _card;
        }

        public double Sconta
        {
            get
            {
                if (card)
                {
                    return prezzo - (prezzo / 100) * 5;
                }
                else
                {
                    return prezzo;
                }
            }

        }
    }
}
