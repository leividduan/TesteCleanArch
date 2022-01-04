using TesteDash.Application.Interfaces;
using TesteDash.Domain.Entities;
using TesteDash.Domain.Interfaces;

namespace TesteDash.Application.Services
{
	public class CategoryService : ServiceBase<Category>, ICategoryService
	{
		private readonly ICategoryRepository _repository;

		public CategoryService(ICategoryRepository repository) : base(repository)
		{
			_repository = repository;
		}
	}
}
