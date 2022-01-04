using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TesteDash.Domain.Interfaces;
using TesteDash.Infra.Data.Context;

namespace TesteDash.Infra.Data.Repositories
{
	public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
	{
		private readonly DashContext _context;
		public RepositoryBase(DashContext context)
		{
			_context = context;
		}
		public bool Add(TEntity entity)
		{
			var entityAdd = _context.Set<TEntity>().Add(entity);
			return entityAdd != null;
		}

		public bool Edit(TEntity entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
			var entityEdit = _context.Set<TEntity>().Update(entity);
			return entityEdit != null;
		}

		public bool Delete(TEntity entity)
		{
			var entityDelete = _context.Set<TEntity>().Remove(entity);
			return entityDelete != null;
		}

		public TEntity GetSingle(Expression<Func<TEntity, bool>> filter = null, string include = null)
		{
			var entity = Get(filter, include);

			return entity.FirstOrDefault();
		}

		public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string include = null)
		{
			var returnEntities = _context.Set<TEntity>().AsNoTracking();

			if (!String.IsNullOrEmpty(include))
				returnEntities = returnEntities.Include(include);
			if (filter != null)
				returnEntities = returnEntities.Where(filter);

			return returnEntities.AsEnumerable();
		}

		public int Save()
		{
			return _context.SaveChanges();
		}
		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
