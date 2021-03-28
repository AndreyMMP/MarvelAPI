using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MarvelAPI.Business.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<List<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(int id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
    }
}
