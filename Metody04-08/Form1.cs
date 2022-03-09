using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double Mocnina(int zaklad, int exponent)
        {
            double vypocet = 1;
            bool expoJeZaporny = exponent < 0;
            exponent = Math.Abs(exponent);

            while (exponent > 0)
            {
                vypocet *= zaklad;
                --exponent;
            }

            if (expoJeZaporny) vypocet = 1 / vypocet;
            return vypocet;
        }

        public static int Faktorial(int cislo)
        {
            int vysledek = 1;
            while (cislo > 0)
            {
                vysledek *= cislo;
                --cislo;
            }
            return vysledek;
        }

        public static int CifLichSoucet(int cislo)
        {
            int cifra = 0;
            int soucet = 0;
            while (cislo > 0)
            {
                cifra = cislo % 10;
                if (cifra % 2 != 0) soucet += cifra;
                cislo /= 10;
            }
            return soucet;
        }

        public static void JePrvocislo(int cislo)
        {
            int pocetDelitelu = 0;
            bool j = false;
            for (int i = 2; i < cislo; i++)
            {
                if (cislo % i == 0) j = true; 
            }
            if (j || cislo == 1) MessageBox.Show("Neni prvocislo.");
            else MessageBox.Show("Je prvocislo.");
        }

        public static int PocetDeliteluSud(int cislo)
        {
            int pocet = 0;
            for (int i = 2; i <= cislo; i+=2)
            {
                if (cislo % i == 0) ++pocet;
            }
            return pocet;
        }

        private void mocnina_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            MessageBox.Show(Mocnina(a, b).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox3.Text);
            MessageBox.Show(Faktorial(c).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d = int.Parse(textBox4.Text);
            MessageBox.Show(CifLichSoucet(d).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int f = int.Parse(textBox5.Text);
            JePrvocislo(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int g = int.Parse(textBox6.Text);
            MessageBox.Show(PocetDeliteluSud(g).ToString());
        }
    }
}
