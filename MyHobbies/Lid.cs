using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public class Lid
    {
        public Lid(string naam, int leeftijd, string geslacht, bool levend)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Geslacht = geslacht;
            Levend = levend;
        }

        public Lid(string naam,  string geslacht, Band band)
        {
            Naam = naam;
            Geslacht = geslacht;
            InBand = band;
        }

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Geslacht { get; set; }
        public bool Levend { get; set; }
        public Band InBand { get; set; }

        public override string ToString()
        {
            return $"{Naam}, {Geslacht}, age {Leeftijd}, alive: {Levend}";
        }
    }
}
