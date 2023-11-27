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
        public bool _card = false;
        Articolo[] articolo;
        public int num;
        public bool cont;

        public Form1()
        {
            InitializeComponent();
            articolo = new Articolo[100];
            num = 0;
            cont = true;
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

            if (cont == true)
            {
                _codice = Convert.ToInt32(textBox1.Text);
                _descrizione = textBox2.Text;
                _prezzo = Convert.ToDouble(textBox3.Text);



                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                if (radioButton1.Checked == true)
                {
                    articolo[num] = new ArticoloAlimentare(_codice, _descrizione, _prezzo, _card);

                    num++;
                }
                if (radioButton2.Checked == true)
                {
                    if (checkBox1.Checked == true)
                    {

                        articolo[num] = new ArticoloNonAlimentare(_codice, _descrizione, _prezzo, _card);

                        num++;
                    }
                    else
                    {
                        articolo[num] = new Articolo(_codice, _descrizione, _prezzo, _card);

                        num++;
                    }
                }
                if (radioButton3.Checked == true)
                {

                    articolo[num] = new AlimentareFresco(_codice, _descrizione, _prezzo, _card);

                    num++;

                }
            }
            else
            {
                listView1.Items.Clear();

                listView1.Items.Add("Cassa chiusa scontrino già fatto,riavviare programma");
            }

            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            double tot=0;

            if (cont == true)
            {

                for (int i = 0; i < num; i++)
                {

                    listView1.Items.Add(articolo[i].Codice.ToString() + " ; " + articolo[i].Descrizione + " ; " + (articolo[i].Sconta()).ToString());

                    tot = tot + articolo[i].Sconta();

                }

                listView1.Items.Add(tot.ToString());

                cont = false;
            }
            else
            {
                listView1.Items.Clear();

               listView1.Items.Add("Scontrino già fatto,riavviare programma");
            }
        }


    }
}
