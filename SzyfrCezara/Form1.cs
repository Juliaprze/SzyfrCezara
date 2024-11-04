using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfrCezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Szyfruj(string tekst, int klucz)
        {
            // Definiujemy polski alfabet
            char[] polskiAlfabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźżAĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSŚTUVWXYZŹŻ".ToCharArray();

            char[] znaki = tekst.ToCharArray(); // Zamieniamy cały tekst na tablicę znaków
            int alfabetLength = polskiAlfabet.Length;

            // Szyfrowanie
            for (int i = 0; i < znaki.Length; i++)
            {
                // Sprawdzamy, czy dany znak należy do polskiego alfabetu
                if (Array.Exists(polskiAlfabet, element => element == znaki[i]))
                {
                    int pozycja = Array.IndexOf(polskiAlfabet, znaki[i]);
                    int nowaPozycja = (pozycja + klucz) % alfabetLength;

                    if (nowaPozycja < 0)
                        nowaPozycja += alfabetLength;

                    znaki[i] = polskiAlfabet[nowaPozycja];
                }
                // Jeżeli znak nie należy do alfabetu (np. spacja, znak interpunkcyjny), pozostawiamy go bez zmian
            }

            return new string(znaki);
        }
        private string Odszyfruj(string tekst, int klucz)
        {
            return Szyfruj(tekst, -klucz); // Deszyfrowanie jest odwrotnością szyfrowania
        }
        private void szyfrowanie_button_Click(object sender, EventArgs e)
        {
            int klucz;
            if (int.TryParse(klucz_txt.Text, out klucz))
            {
                string tekstDoZaszyfrowania = do_zaszyfrowania.Text;
                string zaszyfrowanyTekst = Szyfruj(tekstDoZaszyfrowania, klucz);
                wynik_txt.Text = zaszyfrowanyTekst;
            }
            else
            {
                MessageBox.Show("Proszę podać prawidłowy klucz.");
            }
        }

        private void deszyfrowanie_button_Click_1(object sender, EventArgs e)
        {
            int klucz;
            if (int.TryParse(klucz_txt.Text, out klucz)) // Sprawdzenie, czy klucz jest liczbą
            {
                string tekstDoOdszyfrowania = wynik_txt.Text; // Użycie zaszyfrowanego tekstu jako wejścia
                string odszyfrowanyTekst = Odszyfruj(tekstDoOdszyfrowania, klucz); // Odszyfrowanie tekstu
                wynik_txt.Text = odszyfrowanyTekst; // Wyświetlenie wyniku odszyfrowania
            }
            else
            {
                MessageBox.Show("Proszę podać prawidłowy klucz."); // Obsługa błędu
            }
        }
    }
}
