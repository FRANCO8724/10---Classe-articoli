using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10___Classe_articoli
{
    public partial class Form1 : Form
    {
        public int _codice;
        public string _descrizione;
        public double _prezzo;
        public string _tipo;
        public bool _card = false;
        public string[] _Scontrino = new string[100];
        public int _cont=0;

        public Form1()
        {
            InitializeComponent();
        }     

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _card = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _codice = Convert.ToInt32(textBox1.Text);
            _descrizione = textBox2.Text;
            _prezzo = Convert.ToDouble(textBox3.Text);
            _tipo= textBox4.Text;

            

            textBox1.Text="";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

                Articolo a = new Articolo(_codice, _descrizione, _prezzo, _card, _tipo);

                double sconto = a.Sconta;

                _Scontrino[_cont] = a.Memorizza;


            if (_tipo == "articolo alimentare")
            {
                ArticoloAlimentare b = new ArticoloAlimentare(_codice, _descrizione, sconto, _card, _tipo);

                double sconto2 = b.Sconta2;

                _Scontrino[_cont] = b.Memorizza2;
            }
            if (_tipo == "articolo non alimentare")
            {
                ArticoloNonAlimentare c = new ArticoloNonAlimentare(_codice, _descrizione, sconto, _card, _tipo);

                double sconto3 = c.Sconta3;

                _Scontrino[_cont] = c.Memorizza3;
            }

            _cont++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cont = 0;

            for (int i = 0; i < _Scontrino.Length; i++)
            {
                listView1.Items.Add(_Scontrino[_cont]);
                _cont++;

                if(_Scontrino == null)
                {
                    break;
                }
            }
        }
    }
}
