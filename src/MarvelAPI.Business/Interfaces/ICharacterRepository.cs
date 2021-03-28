using MarvelAPI.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelAPI.Business.Interfaces
{
    public interface ICharacterRepository : IRepository<Character>
    {
        Task<Character> ObterComDetalhes(int id);
        Task<IEnumerable<Character>> ObterTodosComDetalhes();
    }
}
