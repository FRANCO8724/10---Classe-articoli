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
        protected string tipo;
        public string[] Scontrino = new string[100];
        public int cont = 0;
        public bool c = false;

        public Articolo(int _codice, string _descrizione, double _prezzo, bool _card, string _tipo)
        {
            this.codice = _codice;
            this.descrizione = _descrizione;
            this.prezzo = _prezzo;
            this.card = _card;
            this.tipo = _tipo;
        }

        public double Sconta
        {
            get
            {
                if (card)
                {
                    c = true;
                    return prezzo = prezzo - (prezzo / 100) * 5;
                }
                else
                {
                    return prezzo;
                }
            }

        }

        public string Memorizza
        {

            get
            {
                double t = Sconta;

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
    

