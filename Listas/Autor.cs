using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
	internal class Autor
	{
		public int Id { get; set; }
		public string Nome { get; set; }

		public Autor(int id, string nome) {
			Id = id;
			Nome = nome;
		}
		//Body constructor
		public Autor(string nome) => Nome = nome;
		public Autor() { }
		
	}
}
