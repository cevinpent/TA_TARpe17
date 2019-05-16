using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class HeaKangelane : Kangelane
	{
		public override string V6iduk6ne()
		{
			return "Hea võidab alati kurja.";
		}


		public HeaKangelane(string Nimi, string V6ime, string SuperNimi): base (Nimi, SuperNimi, V6ime)
		{


		}
	 
		public string KasutaV6imet(string Nimi, string SuperNimi, string V6ime)
		{
			return ("Hea kangelane " + SuperNimi + "päästab maailma");

		}
	}
}
