using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class Program
	{
        static List<Kangelane> Kangelased= new List<Kangelane>();
        static void LaeKangelased(string Failinimi)
        {
            string[] failiandmed = System.IO.File.ReadAllLines(Failinimi);
            for (int i = 0; i < failiandmed.Length; i++)
            {
                string[] nimikoht = failiandmed[i].Split(new char[] { '/' });
                string nimi = nimikoht[0].Trim();
                string asukoht = nimikoht[1].Trim();
                if (nimi.EndsWith("*"))
                {
                    Kangelased.Add(new Superkangelane(nimi.Trim(new char[] { '*' }), asukoht));

                }
                else
                {
                    Kangelased.Add(new Kangelane(nimi, asukoht));

                }

            }

        }
		static void Main(string[] args)
		{



		}
	}
}
