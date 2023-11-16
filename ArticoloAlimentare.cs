using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    internal class ArticoloAlimentare : Articolo
    {
        private double prezzo2;
        private int anno;

        public ArticoloAlimentare(int _codice, string _descrizione, double _prezzo, bool _card, string _tipo) : base( _codice,  _descrizione,  _prezzo,  _card, _tipo)
        {
            this.prezzo2 = _prezzo;
            Random random = new Random();
            anno = random.Next(DateTime.Now.Year, DateTime.Now.Year+3);
        }

        public double Sconta2
        {
            get
            {
                if (anno == DateTime.Now.Year)
                {
                    c = true;
                    return prezzo2 = prezzo2 - (prezzo2 / 100) * 20;
                }
                else
                {
                    return prezzo2;
                }
            }

        }

        public string Memorizza2
        {

            get
            {
                double t = Sconta2;

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
