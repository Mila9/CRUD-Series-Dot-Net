using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Series
{
    public class Validacao
    {
		public bool ValidaTitulo(string titulo,List<Serie> lista)
		{
			foreach (var tituloSerie in lista)
			{

				if (!tituloSerie.retornaTitulo().Trim().Equals(titulo.Trim()))
				{
					Console.WriteLine("Titulo valido");
					lista.Add(tituloSerie);
				
				}
				else
				{
					Console.WriteLine("Insira um titulo valido");
					return false;
				}

			}
			return true;
		}
	}
}
