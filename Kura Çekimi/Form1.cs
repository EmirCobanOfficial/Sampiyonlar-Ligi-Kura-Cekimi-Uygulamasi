using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kura_Çekimi
{
    public partial class Form1 : Form
    {
        List<Takim> Takimlar;
            List<ListBox> Torbalar = new List<ListBox>();
        List<ListBox> Grublar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;

            Takimlar = new List<Takim>();

            yenitakim = new Takim("Bayern Münih", "Almanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("FC Barcelona", "Éspanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Chelsea", "ingiltere");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "ispanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "Ingiltere");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Arsenal", "Ingiltere");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Benfica", "Portekiz");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "Ispanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Shaktar Donetsk", "Ukrayna");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "Italya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Schalke 04", "Almanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Marsilya", "Fransa");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("CSKA Moskova", "Rusya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Paris-Saint Germain","Fransa");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "italya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim ("Zenit","Rusya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Machester City", "Ingiltere");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim ("Basel","isvicre");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussia Dortmund","Almanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympiakos","Yunanistan");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Fenerbahce", "Türkiye");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Napoli", "Italya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Celtic", "iskoçya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Victoria Plzen", "Cek Cunhuriyeti");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Austria Wien", "Avusturya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Sociedad", "ispanya");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Besiktas", "Türkiye");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("TrabzonSpor", "Türkiye");
            Takimlar.Add(yenitakim);
            yenitakim = new Takim("Roma", "İtalya");
            Takimlar.Add(yenitakim);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int i = 0; i < Takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0, Takimlar.Count);
                if (secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i<8)
                {
                    lsttorba1.Items.Add(Takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    lsttorba2.Items.Add(Takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    lsttorba3.Items.Add(Takimlar[secilentakimlar[i]]);
                }
                else
                {
                    lsttorba4.Items.Add(Takimlar[secilentakimlar[i]]);
                }
            }
            Torbalar.Add(lsttorba1);
            Torbalar.Add(lsttorba2);
            Torbalar.Add(lsttorba3);
            Torbalar.Add(lsttorba4);

            Grublar.Add(listBox1);
            Grublar.Add(listBox2);
            Grublar.Add(listBox3);
            Grublar.Add(listBox4);
            Grublar.Add(listBox5);
            Grublar.Add(listBox6);
            Grublar.Add(listBox7);
            Grublar.Add(listBox8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> seçilentakımlar = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                seçilentakımlar.Clear();
                for (int j = 0; j < 8; j++)
                {
                    int seçilentakım = rastgele.Next(0, Takimlar.Count / 4);
                    if (seçilentakımlar.Contains(seçilentakım)) // seçilentakımların içinde seçlen takım var mı
                    {
                        j--;
                    }
                    else
                    {
                        seçilentakımlar.Add(seçilentakım);
                    }
                }
                bool aynıulkedentakımvar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakımvar = aynıulkedentakımvarmı(Grublar[k], Torbalar[i].Items[seçilentakımlar[k]] as Takim);
                    if (aynıulkedentakımvar)
                        break;
                }
                if (!aynıulkedentakımvar)
                {
                    listBox1.Items.Add(Torbalar[i].Items[seçilentakımlar[0]] as Takim);
                    listBox2.Items.Add(Torbalar[i].Items[seçilentakımlar[1]] as Takim);
                    listBox3.Items.Add(Torbalar[i].Items[seçilentakımlar[2]] as Takim);
                    listBox4.Items.Add(Torbalar[i].Items[seçilentakımlar[3]] as Takim);
                    listBox5.Items.Add(Torbalar[i].Items[seçilentakımlar[4]] as Takim);
                    listBox6.Items.Add(Torbalar[i].Items[seçilentakımlar[5]] as Takim);
                    listBox7.Items.Add(Torbalar[i].Items[seçilentakımlar[6]] as Takim);
                    listBox8.Items.Add(Torbalar[i].Items[seçilentakımlar[7]] as Takim);
                }
                else
                {
                    i--;
                }
            }
        }
        private bool aynıulkedentakımvarmı(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TeamCountry==takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }
    }
}
