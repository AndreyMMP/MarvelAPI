using MarvelAPI.Business.Interfaces;
using MarvelAPI.Business.Models;
using MarvelAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelAPI.Data.Repository
{
    public class CharacterRepository : Repository<Character>, ICharacterRepository
    {
        public CharacterRepository(MyDbContext context) : base(context) { }

        public async Task<Character> ObterComDetalhes(int id)
        {
            return await _context.Character.AsNoTracking().Include(x => x.CharacterInformations).FirstOrDefaultAsync(y => y.Id == id);
        }

        public async Task<IEnumerable<Character>> ObterTodosComDetalhes()
        {
            return await _context.Character.AsNoTracking().Include(x => x.CharacterInformations).ToListAsync();
        }
    }
}
