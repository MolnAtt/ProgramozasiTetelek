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

		static void Main(string[] args)
		{

			Koszones();

			List<int> szamlista = new List<int> { 1, 5, 4, 9, 7, -1, 3, -2, -3, -3, 9, 0, 4, 5, 6, 4, 5, 4, 4, 4, 3 };
			List<int> pici_szamlista = new List<int> { -1, -2, -3, -4};

			Console.WriteLine("a szamlista-ban szereplő számok összege:");

			Console.WriteLine(Osszeg2(szamlista));

			Console.WriteLine("A legnagyobb szám a sorozatban:");
			Console.WriteLine(Max2(szamlista));


			Console.ReadKey();
		}

	}
}
