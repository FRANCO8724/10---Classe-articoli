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
        private int anno;

        public ArticoloAlimentare(int _codice, string _descrizione, double _prezzo, bool _card) : base( _codice,  _descrizione,  _prezzo,  _card)
        {
            Random random = new Random();
            anno = random.Next(DateTime.Now.Year, DateTime.Now.Year+3);
        }

        public override double Sconta
        {
            get
            {
                if (anno == DateTime.Now.Year)
                {
                    return _prezzo = _prezzo - (_prezzo / 100) * 20;
                }
                else
                {
                    return _prezzo;
                }
            }

        }

    }
}
