using MarvelAPI.Business.Interfaces;
using MarvelAPI.Business.Models;
using MarvelAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MarvelAPI.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly MyDbContext _context;
        protected readonly DbSet<TEntity> DbSet;
        public Repository(MyDbContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        Task<TEntity> IRepository<TEntity>.ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
