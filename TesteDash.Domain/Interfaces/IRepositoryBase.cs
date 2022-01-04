﻿using System.Linq.Expressions;

namespace TesteDash.Domain.Interfaces
{
	public interface IRepositoryBase<TEntity> where TEntity : class
	{
		public TEntity GetSingle(Expression<Func<TEntity, bool>> filter = null, string include = null);
		public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string include = null);
		public bool Add(TEntity entity);
		public bool Edit(TEntity entity);
		public bool Delete(TEntity entity);
		public int Save();
		public void Dispose();
	}
}
