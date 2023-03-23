using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
	internal class Curso
	{
		public int Codigo;
		public string NomeCurso;
		public Curso(int cod, string nome)
		{
			this.Codigo = cod;
			this.NomeCurso = nome;
		}
	}
}
