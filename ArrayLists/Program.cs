using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace ArrayLists
{
	internal class Program
	{
		public static void ExibeLista(ArrayList array)
		{
			//Trabalhando com um único tipo
			/*foreach (string i in array)
			{
				Console.WriteLine( i );
			}*/

			//Trabalhando com tipos diferentes
			for (int i =0; i < array.Count; i++)
			{
				Console.WriteLine(array[i]);
			}
			Console.WriteLine("\n---------------------\n");
			
			
		}

		public static void ExibeListTipo(List<string> array)
		{
			Console.WriteLine("\n---------------------\n");
			Console.WriteLine("List<>\n");
			//Trabalhando com um único tipo
			foreach (string i in array)
			{
				Console.WriteLine( i );
			}
			Console.WriteLine("\n---------------------\n");
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			ArrayList teste = new ArrayList();
			teste.Add("Ana");
			teste.Add("Eliane");
			teste.Add("Maria");
			teste.Add("Eliane");
			teste.Add(1);
			teste.Add(true);
			ExibeLista(teste);

			Console.WriteLine("Numero de elementos na lista: " + teste.Count);

			string achou = teste.Contains("eliane") ? "Encontrou" : "Não encontrou";
			Console.WriteLine(achou);
			//teste.Clear();
			ExibeLista(teste);
			//Console.WriteLine(teste.GetType().ToString());

			List<string> agenda = new List<string>();

			agenda.Add("Bezerra da Silva;11 1111-1111");
			agenda.Add("Paulo Ricardo;22 2222-2222");
			agenda.Add("Roberto Carlos;33 3333-3333");
			agenda.Add("Morais Moreira;44 4444-4444");
			ExibeListTipo(agenda);

			agenda.ForEach(s => Console.WriteLine(s));

		
			Usuario u1 = new Usuario();
			u1.Id = 1;
			u1.Nome = "admin";

			Usuario u2 = new Usuario();
			u2.Id = 2;
			u2.Nome = "eliane";

			List<Usuario> lista = new List<Usuario>();
			lista.Add(u1);
			lista.Add(u2);
			
			Console.WriteLine("Quantidade: " + lista.Count);

			lista.ForEach(elemento =>
			{
				Console.WriteLine("Id: " + elemento.Id);
				Console.WriteLine("Nome: " + elemento.Nome);
			});

			var valores = new List<int> { -5,-2,-1,-10,0,15,1,2,8,7};

			List<int> filtro = valores.FindAll(e => e > 0);
			
			
			Console.WriteLine(string.Join(',', filtro));


		}
	}
}