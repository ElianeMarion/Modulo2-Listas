using System.Linq;

namespace Listas
{
	internal class Program
	{
		static void Main(string[] args)
		{
/*
			SortedSet<string> alunos = new SortedSet<string>();

			// Adicionando elementos na lista
			alunos.Add("Alberto");
			alunos.Add("Giovanna");
			alunos.Add("Fabio");
			alunos.Add("Victor");
			alunos.Add("Carlos");
			Console.Write("Encontrou o aluno Carlos: ");
			// Procurando na lista um determinado elemento
			Console.WriteLine(alunos.Contains("Carlos"));
			Console.WriteLine("");
			foreach (string aluno in alunos)
			{
				Console.WriteLine(aluno);
			}
			Console.Read();

			*/
			List<Autor> lista = new List<Autor>();
			
			
			lista.Add(new Autor(1, "Aaron Korsh" ));
			Autor autor1 = new Autor();
			autor1.Id = 1;
			autor1.Nome = "Nora Zuckerman";
			lista.Add(autor1);
			Autor autor2 = new Autor(2, "Chris Downey");
			lista.Insert(1, autor2);
		
			foreach (Autor a in lista)
			{
				Console.WriteLine(a.Nome);
			}

			Personagem p = new Personagem();
			p.Id = 1;
			p.NomePersonagem = "Harvey Specter";
			p.Ator = "Gabriel Macht";

			Personagem p2 = new Personagem();
			p.Id = 2;
			p.NomePersonagem = "Mike Ross";
			p.Ator = "Patrick J. Adams";

			Serie suits = new Serie();
			suits.Id = 1;
			suits.Nome = "Suits";
			suits.NumeroEpisodios = 134;
			suits.NumeroTemporadas = 9;
			suits.Autores = lista;

			/*Console.WriteLine("\n-------------------------\nRemovendo itens" +
				"\n-------------------------\n");
			lista.Remove(autor2);

			foreach (Autor a in lista)
			{
				Console.WriteLine(a.Nome);
			}*/
			/*
			List<string> nomes = new List<string>();
			nomes.Add("Eliane");
			nomes.Add("Bianca");
			nomes.Add("Maria");
			nomes.Insert(1, "Kaique");
			nomes.Add("Maria");
			nomes.Add("Maria");
			Console.WriteLine("Digite o próximo nome da lista: ");
			nomes.Add(Console.ReadLine());
			foreach (string a in nomes)
			{
				Console.WriteLine(a);
			}
			Console.WriteLine("\n-------------------------\nRemovendo itens" +
				"\n-------------------------\n");
			nomes.Remove("Maria");
			foreach (string a in nomes)
			{
				Console.WriteLine(a);
			}


			Console.WriteLine("\n-------------------------\nRemovendo itens pela posição" +
			"\n-------------------------\n");
			nomes.RemoveAt(3);
			foreach (string a in nomes)
			{
				Console.WriteLine(a);
			}

			Console.WriteLine("Quantidade de elementos da lista: " + nomes.Count());
			/*

			Console.WriteLine("\n-------------------------\nRemovendo itens" +
				"\n-------------------------\n");
			lista.Remove(autor1);
			//lista.RemoveAt(2);
			foreach (Autor a in lista)
			{
				Console.WriteLine(a.Nome);
			}

			//lista.Remove(autor1);
			lista.RemoveAt(2);
			foreach (Autor a in lista)
			{
				Console.WriteLine(a.Nome);
			}
			/*
			Console.WriteLine("Hello, World!");
			List<Produto> listaProdutos = new List<Produto>();
			Produto produto1 = new Produto();
			produto1.Nome = "Maca";
			produto1.Quantidade = 100;

			Produto produto2 = new Produto();

			produto2.Nome = "Banana";
			produto2.Quantidade = 100;

			
			//Adicionar um elemento na lista
			listaProdutos.Add(produto1);
			listaProdutos.Add(produto2);

			//Exibindo elementos da lista
			foreach (Produto produto in listaProdutos)
			{
				Console.WriteLine(produto.Nome);
			}

			//Alterando um elemento da lista
			listaProdutos[0].Nome = "Maçã";
			listaProdutos[0].Quantidade = 12;

			//Removendo elemento da lista
			listaProdutos.RemoveAt(0);
			listaProdutos.Remove(produto2);*/




		}


	}
}