//using CasaDoCodigo.Migrations;
using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria>CategoriaNova(string nome);
    }

    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {

        }

		public async Task<Categoria>CategoriaNova(string nome)
		{
			var categoria = dbSet.Where(c => c.CategoriaNome == nome).SingleOrDefault();

			if (categoria == null)
			{
				var novaCategoria = new Categoria()
				{
					CategoriaNome = nome
				};
				categoria = dbSet.Add(novaCategoria).Entity;

			}
			await contexto.SaveChangesAsync();
			return categoria;
		}
	}
}
