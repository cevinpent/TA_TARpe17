using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {
        private string nimi;

        private string asukoht;

        protected string Nimi { get => nimi; set => nimi = value; }
        protected string Asukoht { get => asukoht; set => asukoht = value; }

        public Kangelane(string Nimi, string Asukoht)
        {
            this.Nimi = Nimi;
            this.Asukoht = Asukoht;
        }
        public int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * .95);
        }
        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + "turvalisena.";
        }
    }
}
