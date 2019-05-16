﻿using System;
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

		private string superNimi;

		private string v6ime;



        protected string Nimi { get => nimi; set => nimi = value; }
        protected string Asukoht { get => asukoht; set => asukoht = value; }
		public string SuperNimi { get => superNimi; set => superNimi = value; }
		public string V6ime { get => v6ime; set => v6ime = value; }

		public Kangelane(string Nimi, string Asukoht)
        {
            this.Nimi = Nimi;
            this.Asukoht = Asukoht;
        }

		public Kangelane(string Nimi, string SuperNimi, string V6ime)
		{

			this.Nimi = Nimi;
			this.SuperNimi = SuperNimi;
			this.V6ime = V6ime;

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
