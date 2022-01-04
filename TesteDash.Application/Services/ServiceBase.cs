using System.Linq.Expressions;
using TesteDash.Application.Interfaces;
using TesteDash.Domain.Interfaces;

namespace TesteDash.Application.Services
{
	public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
	{
		private readonly IRepositoryBase<TEntity> _repository;
		public ServiceBase(IRepositoryBase<TEntity> repository)
		{
			_repository = repository;
		}

		public bool Add(TEntity entity)
		{
			return _repository.Add(entity);
		}

		public bool Edit(TEntity entity)
		{
			return _repository.Edit(entity);
		}

		public bool Delete(TEntity entity)
		{
			return _repository.Delete(entity);
		}

		public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string include = null)
		{
			return _repository.Get(filter, include);
		}

		public TEntity GetSingle(Expression<Func<TEntity, bool>> filter = null, string include = null)
		{
			return _repository.GetSingle(filter, include);
		}

		public int Save()
		{
			return _repository.Save();
		}

		public void Dispose()
		{
			_repository.Dispose();
		}
	}
}
