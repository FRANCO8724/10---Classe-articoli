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
        private int _anno;

        public int Anno
        {
            get { return _anno; }
            set { _anno = value; }
        }

        public ArticoloAlimentare(int codice, string descrizione, double prezzo, bool card) : base( codice,  descrizione,  prezzo,  card)
        {
            Random random = new Random();
            _anno = random.Next(DateTime.Now.Year, DateTime.Now.Year+3);
        }

        public override double Sconta()
        {

            double prezzoScontato = base.Sconta();

            if (prezzoScontato == DateTime.Now.Year)
            {
               return prezzoScontato = prezzoScontato - (prezzoScontato / 100) * 20;
            }
            else
            {
                return prezzoScontato;
            }


        }

    }
}
