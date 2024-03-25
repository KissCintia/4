using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Nyilvantartas
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public string Nemzetiseg { get; set; }
        public string Foglalkozas { get; set; }
        public string Erdeklodes { get; set; }

        public Nyilvantartas(string nev, int eletkor, string nemzetiseg, string foglalkozas, string erdeklodes)
        {
            Nev = nev;
            Eletkor = eletkor;
            Nemzetiseg = nemzetiseg;
            Foglalkozas = foglalkozas;
            Erdeklodes = erdeklodes;
        }

        public Nyilvantartas(string sor)
        {
            string[] a = sor.Split(';');
            Nev = a[0];
            Eletkor = Convert.ToInt32(a[1]);
            Nemzetiseg = a[2];
            Foglalkozas = a[3];
            Erdeklodes = a[4];
        }
        public override string? ToString()
        {
            return "Nevem " + Nev + ", " + Eletkor + " éves vagyok, " + Nemzetiseg + " származású, " 
                + Foglalkozas + " a foglalkozásom, " + Erdeklodes + " érdekel.";
        }
    }
}
