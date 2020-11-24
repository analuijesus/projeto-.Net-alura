using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
	public class BuscaDeProdutoViewModel
	{
		public BuscaDeProdutoViewModel(IList<Produto> produtos, bool resultadoBusca)
		{
			this.Produtos = produtos;
			this.ResultadoBusca = resultadoBusca;
		}

		public IList<Produto> Produtos { get; set; }

		public BuscaDeProdutoViewModel(bool encontrouResultados)
		{
			ResultadoBusca = encontrouResultados;
		}

		public string Pesquisa { get; set; }
		public bool ResultadoBusca;
	}
}
