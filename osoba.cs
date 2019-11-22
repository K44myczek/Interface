using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejss
{
    class osoba :IComparable<osoba>
    {
        private string imie;
        private string nazwisko;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public osoba(string imie, string nazwisko)
        {
            this.imie=imie;
            this.nazwisko = nazwisko;
        }

        public int CompareTo(osoba other)
        {
            int result = 0;
            result = nazwisko.CompareTo(other.nazwisko);
            if (result==0)
            {
                result = nazwisko.CompareTo(other.nazwisko);
            }
            return result;
        }
    }
}
