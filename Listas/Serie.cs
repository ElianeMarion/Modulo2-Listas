using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
	internal class Serie
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public int NumeroEpisodios { get; set; }
		public int NumeroTemporadas { get; set; }

		//public Autor Autor { get; set; }
		public List<Autor> Autores { get; set; }
		public List<Personagem> Personages { get; set; }

	}
}
