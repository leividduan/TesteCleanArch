using TesteDash.Domain.Entities;
using TesteDash.Domain.Interfaces;
using TesteDash.Infra.Data.Context;

namespace TesteDash.Infra.Data.Repositories
{
	public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
	{
		private readonly DashContext _context;
		public CategoryRepository(DashContext context) : base(context)
		{
			_context = context;
		}
	}
}
