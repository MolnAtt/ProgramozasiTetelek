using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
	class Program
	{
		static void Koszones()
		{
			Console.WriteLine("Programozási tételek következnek");
		}

		static int Osszeg1(List<int> lista)
		{
			int s = 0;
			for (int i = 0; i < lista.Count; i++)
			{
				//s = s + lista[i];
				s += lista[i];
			}
			return s;
		}

		static int Osszeg2(List<int> lista)
		{
			int s = 0;
			foreach (int elem in lista)
			{
				s += elem;
			}
			return s;
		}

		static int Max1(List<int> lista)
		{
			int m = lista[0]; // első elemet veszi fel, nem 0-át!!!!
			for (int i = 1; i < lista.Count; i++) // 1-től indul!!!
			{
				if (m < lista[i])
				{
					m = lista[i];
				}
			}
			return m;
		}

		static int Max2(List<int> lista)
		{
			int m = lista[0];
			foreach (int elem in lista) // itt most keményen megvizsgáltuk azt is, hogy saját magánál nagyobb-e...
			{
				if (m < elem)
				{
					m = elem;
				}
			}
			return m;
		}

		static int Min1(List<int> lista)
		{
			int m = lista[0];
			for (int i = 1; i < lista.Count; i++)
			{
				if (lista[i]  <m)
				{
					m = lista[i];
				}
			}
			return m;
		}

		static int Szorzat(List<int> lista)
		{
			int p = lista[0];
			for (int i = 1; i < lista.Count; i++)
			{
				p *= lista[i];
			}
			return p;
		}


		static int Parosak_szama1(List<int> lista)
		{
			int db = 0;
			foreach (int elem in lista)
			{
				if (elem % 2 == 0)
				{
					db++;
				}
			}
			return db;
		}

		static int Parosak_szama2(List<int> lista)
		{
			int db = 0;
			for (int i = 0; i < lista.Count; i++)
			{
				if (lista[i] % 2 == 0)
				{
					db++;
				}
			}
			return db;
		}

		static int SzomszedosParosok1(List<int> lista) // ez foreach-csel csak segédváltozóval fog menni!
		{
			int db = 0;

			for (int i = 1; i < lista.Count; i++)
			{
				if (lista[i] % 2 == 0 && lista[i - 1] % 2 == 0)
				{
					db++;
				}
			}

			return db;
		}

		static int MinuszPluszMinusz(List<int> lista) 
		{
			int db = 0;
			for (int i = 2; i < lista.Count; i++)
			{
				if (0 < lista[i - 2] && lista[i - 1] < 0 && 0 < lista[i])
				{
					db++;
				}
			}
			return db;
		}

		static int Maxhely(List<int> lista)
		{
			int mi = 0;

			for (int i = 1; i < lista.Count; i++)
			{
				if (lista[mi] < lista[i])
				{
					mi = i;
				}
			}

			return mi;
		}

		static List<int> Kivalogat_negativ(List<int> lista)
		{
			List<int> result = new List<int>();

			foreach (int elem in lista)
			{
				if (elem<0)
				{
					result.Add(elem);
				}
			}

			return result;
		}

		static void Lista_kiirasa(List<int> lista)
		{
			//Console.WriteLine(lista); // ez nem fog menni c#-ban
			foreach (int elem in lista)
			{
				Console.Write(elem);
				Console.Write(" ");
			}
			Console.WriteLine();
		}

		static void Lista_kiirasa_vesszovel(List<int> lista)
		{
			if (0 < lista.Count)
			{
				for (int i = 0; i < lista.Count - 1; i++)
				{
					Console.Write(lista[i]);
					Console.Write(", ");
				}
				Console.Write(lista[lista.Count - 1]);

				Console.WriteLine();
			}
		}

		static List<int> Negyzetek(List<int> lista)
		{
			List<int> result = new List<int>();

			foreach (int elem in lista)
			{
				result.Add(elem * elem);
			}

			return result;
		}

		static int Helye(int szam, List<int> lista)
		{
			int i = 0;

			while (i < lista.Count && !(lista[i] == szam))
			{
				i++;
			}
			
			//! ezen a helyen, tehát egy while ciklus után MINDIG hamis a ciklusfeltétel
			// lista[i] == szam VAGY i == lista.Count

			return i;
		}

		static bool Van_e(int szam, List<int> lista)
		{
			return Helye(szam, lista) < lista.Count;			
		}
		// static bool Van_e(int szam, List<int> lista) => Helye(szam, lista) < lista.Count;

		static int Keresés(int szam, List<int> lista) // -1-et ad vissza, ha nincs benne a listában.
		{
			int h = Helye(szam, lista); // azért kell elmenteni külön változóba, hogy ne kétszer számolja ki!
			return h < lista.Count ? h : -1;
		}

		static int Kiválasztás(int szam, List<int> lista) // meg van ígérve, hogy van ilyen a listában. Kell az indexe
		{
			int i = 0;

			while (!(lista[i] == szam))
			{
				i++;
			}

			return i;
		}

		static Dictionary<char, int> Karakterek_előfordulásainak_számai(string szoveg)
		{
			Dictionary<char, int> karakterszótár = new Dictionary<char, int>();

			foreach (char karakter in szoveg)
			{
				if (karakterszótár.ContainsKey(karakter))
				{
					karakterszótár[karakter] += 1;
				}
				else // azaz ha nem volt még ilyen kulcs... azaz akkor ez az első!
				{
					karakterszótár[karakter] = 1;
				}
			}

			return karakterszótár;
		}

		static Dictionary<int, int> Maradék_szerinti_csoportosítás(List<int> számlista, int osztó)
		{
			Dictionary<int, int> szótár = new Dictionary<int, int>();

			foreach (int szám in számlista)
			{
				int kulcs = szám % osztó;
				if (szótár.ContainsKey(kulcs))
				{
					szótár[kulcs] += 1;
				}
				else
				{
					szótár[kulcs] = 1;
				}
			}

			return szótár;
		}

		static Dictionary<int, List<int>> Maradék_szerinti_csoportosítás2(List<int> számlista, int osztó)
		{
			Dictionary<int, List<int>> szótár = new Dictionary<int, List<int>>();
			foreach (int szám in számlista)
			{
				int kulcs = szám % osztó;
				if (szótár.ContainsKey(kulcs))
				{
					szótár[kulcs].Add(szám);
				}
				else // ha nincs ilyen kulcs...
				{
					szótár[kulcs] = new List<int> { szám }; // akkor csináljunk egy új listát a számmal benne!
				}
			}
			return szótár;
		}


		static void Main(string[] args)
		{

			Koszones();

			List<int> szamlista = new List<int> { 1, 5, 4, 9, 7, -1, 3, -2, -3, -3, 9, 0, 4, 5, 6, 4, 5, 4, 4, 4, 3 };
			List<int> pici_szamlista = new List<int> { -1, -2, -3, -4};
			List<int> ureslista = new List<int>();

			Console.WriteLine("a szamlista-ban szereplő számok összege: (Összegzés Prog. thm.)");

			Console.WriteLine(Osszeg2(szamlista));

			Console.WriteLine("A legnagyobb szám a sorozatban: (Maximumkiválasztás Prog. thm.)");
			Console.WriteLine(Max2(szamlista));

			Console.WriteLine("legkisebb szám:");
			Console.WriteLine(Min1(szamlista));
			Console.WriteLine("A számok szorzata:");
			Console.WriteLine(Szorzat(pici_szamlista));
			//Console.WriteLine(Szorzat(ureslista));

			Console.WriteLine("Hány darab páros szám van? ((Feltételes) Megszámlálás Prog. thm.)");
			Console.WriteLine(Parosak_szama1(szamlista));
			Console.WriteLine(Parosak_szama2(szamlista));
			Console.WriteLine("Hány olyan helyzet van, hogy két páros szám egymás mellett szerepel?");
			Console.WriteLine(SzomszedosParosok1(szamlista));
			Console.WriteLine("Hány olyan helyzet van, hogy egy negatív szám két pozitív szám közt van?");
			Console.WriteLine(MinuszPluszMinusz(szamlista));
			Console.WriteLine("Púpnak nevezzük azon számokat, amelyek nagyobbak mindkét szomszedjuknál. Hány púp van?");
			Console.WriteLine("Hány olyan szomszédos számhármas van, ahol az első kettő összege a harmadik?");
			Console.WriteLine("Milyen indexű helyen van a legnagyobb elem?");
			Console.WriteLine(Maxhely(szamlista));
			Console.WriteLine("Válogasd ki a negatív számokat!");
			List<int> negativok = Kivalogat_negativ(szamlista);

			Lista_kiirasa(negativok);
			Lista_kiirasa_vesszovel(negativok);

			Console.WriteLine("Add meg a listában szereplő számok négyzeteit!");
			List<int> negyzetek = Negyzetek(szamlista);
			Lista_kiirasa_vesszovel(negyzetek);

			Console.WriteLine("Van-e benne 0?");
			int result = Helye(1000, szamlista);
			Console.WriteLine(result);

			#region Tutorial: Szótár adatszerkezet
			/* Kitérő, hogy működik a szótár adatszerkezet? */
			Console.WriteLine("szótárteszt");
			Dictionary<string, int> szótár = new Dictionary<string, int>();
			Console.WriteLine(szótár.Count);
			// ilyet lehet, de nem így szoktuk...
			szótár.Add("V. Laci", 184); // 2 érték kell!
			szótár.Add("B. Zsombor", 185);
			Console.WriteLine(szótár.Count);
			Console.WriteLine($"Laci magassága: {szótár["V. Laci"]}");
			// így szoktunk értékeket beleírni valójában...
			szótár["S. Zsombor"] = 197; // ez most nem kifagy, hanem létrehozza ezt a key-value pairt!
			Console.WriteLine($"S. Zsombor magassága: {szótár["S. Zsombor"]}");
			szótár["S. Zsombor"] = 198; // ez most nem kifagy, hanem létrehozza ezt a key-value pairt!
			Console.WriteLine($"S. Zsombor magassága: {szótár["S. Zsombor"]}");
			// tehát ha van ilyen érték, akkor átírja, ha nincs, (akkor nem kifagy, hanem) létrehozza

			// És most írjuk ki a szótár ÖSSZES elemét!
			// számláló vagy while ciklus nem lesz, mivel nem számokkal indexel!
			// csak foreach-csel lehet dolgozni!
			// nem így szoktuk, de megmutatom
			Console.WriteLine("Mindenki magassága:");
			foreach (KeyValuePair<string, int> pár in szótár)
			{
				Console.WriteLine($"{pár.Key} magassága: {pár.Value}");
			}
			// így szoktuk inkább, mert így minden sokkal egyszerűbb! és szebb is, jobban hasonlít a függvényekre...
			Console.WriteLine("mégegyszer, szótárasabban:");
			foreach (string kulcs in szótár.Keys) // a kulcsokon megyünk végig! azok egyszerűek!
			{
				Console.WriteLine($"{kulcs} magassága: {szótár[kulcs]}");
			}

			Console.WriteLine($"van-e benne \"V. Lacii\" kulcs? {szótár.ContainsKey("V. Lacii")}");

			/* szótárokról szóló tutorial vége */
			#endregion

			string szoveg = "asjk.ecghvrbfasjkéerfgbvaéerkujgcvnzapeé45iuvtznap3e4iétuvqbn34p5é9v783bé9t78t3bn4pv9éq734";

			Console.WriteLine($"A \"{szoveg}\" szövegben a következő karakterek előfordulásainak a száma:");

			// emlékezzünk, a string egy csak olvasható karakterlista!

			Dictionary<char, int> karakterszotar = Karakterek_előfordulásainak_számai(szoveg);

			// kiírás:

			foreach (char kulcs in karakterszotar.Keys)
			{
				Console.WriteLine($"{kulcs}: {karakterszotar[kulcs]} db");
			}

			Console.WriteLine("Csoportosítsd a számlistában szereplő számokat a hárommal való osztási maradékuk szerint! Melyikből mennyi van?");


			Dictionary<int, int> számszótár = Maradék_szerinti_csoportosítás(szamlista, 3);
			foreach (int kulcs in számszótár.Keys)
			{
				Console.WriteLine($"{kulcs} maradékot ad: {számszótár[kulcs]} db");
			}


			Console.WriteLine("Csoportosítsd a számlistában szereplő számokat a hárommal való osztási maradékuk szerint! Melyek ezek a csoportok?");

			Dictionary<int, List<int>> számszótár2 = Maradék_szerinti_csoportosítás2(szamlista, 4);
			foreach (int kulcs in számszótár2.Keys)
			{
				Console.Write($"{kulcs} maradékot ad: ");
				// számszótár2[kulcs] --> ez most most a számok listája!
				foreach (int elem in számszótár2[kulcs])
				{
					Console.Write(elem);
					Console.Write(" ");
				}
				Console.WriteLine();
			}

			Console.ReadKey();
		}

	}
}
