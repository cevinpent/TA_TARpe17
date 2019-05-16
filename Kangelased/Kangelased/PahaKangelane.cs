using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class PahaKangelane : Kangelane
	
	{

		public override string V6iduk6ne()
		{
			return "Lõpuks ometi ma võitsin";
		}
		public PahaKangelane(string Nimi, string SuperNimi, string v6ime) : base(Nimi, SuperNimi, v6ime)
		{
			

		}
		public string KasutaV6imet(string Nimi, string SuperNimi, string V6ime)
		{
			return ("Paha kangelane " + SuperNimi + " püüab hävitada maailma");

		}
	}
}
