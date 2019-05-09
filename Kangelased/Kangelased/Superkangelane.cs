using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Superkangelane:Kangelane
    {
        private double _osavus;

        public Superkangelane(string Nimi, string Asukoht):base(Nimi,Asukoht)
        {
            Random r = new Random();
            _osavus = r.Next(1,5)+r.NextDouble();
        }

        public override int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid*(95+_osavus)/100);
        }
        public override string ToString()
        {
            return base.ToString()+"ja ta on selles"+_osavus+"protsenti osavam kui teised.";
        }
    }
}
