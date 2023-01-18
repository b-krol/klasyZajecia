using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasyiobiekty.przykladyklas
{
    internal class Osoba
    {
        private string? narodowosc;
        private string imie, nazwisko;
        private char? plec;
        public DateTime dtUrodzenia
        {
            get { return dtUrodzenia; }
            set
            {
                if (value > DateTime.Now)
                    dtUrodzenia = DateTime.Now;
                else dtUrodzenia = value; 
            }
        }
        

        //konstruktor
        public Osoba(string imie, string nazwisko, string narodowosc, DateTime dtUrodzenia, char? plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
            this.dtUrodzenia = dtUrodzenia;
            this.plec = plec;
        }

        public Osoba(string imie, string nazwisko, DateTime dtUrodzenia, char? plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dtUrodzenia = dtUrodzenia;
            this.plec = plec;
        }

        public string Wypisz()
        {
            if (narodowosc == null) narodowosc = "Narodowość nie znana";
            return $"{this.imie} {this.nazwisko}\n" +
                $"{narodowosc}\n" +
                $"{this.dtUrodzenia.ToString("D")}\n" +
                $"{plec}\n";
        }
    }
}
