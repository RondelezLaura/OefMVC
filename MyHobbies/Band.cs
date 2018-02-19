using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public class Band
    {
        public Band(string naam, int jaar)
        {
            Naam = naam;
            Jaar = jaar;
        }
        public Band(string naam, int jaar, List<Lid> leden)
        {
            Naam = naam;
            Jaar = jaar;
            Leden = leden;
        }

        public string Naam { get; set; }
        public int Jaar { get; set; }
        public List<Lid> Leden { get; set; }

        public override string ToString()
        {
            string s = "";
            s += Naam + ", " + Jaar;
            foreach (Lid lid in Leden)
            {
                s += lid;
            }
            return $"{s}";
        }
    }
}
