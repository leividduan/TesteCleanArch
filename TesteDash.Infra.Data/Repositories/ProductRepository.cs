using TesteDash.Domain.Entities;
using TesteDash.Domain.Interfaces;
using TesteDash.Infra.Data.Context;

namespace TesteDash.Infra.Data.Repositories
{
	public class ProductRepository : RepositoryBase<Product>, IProductRepository
	{
		private readonly DashContext _context;
		public ProductRepository(DashContext context) : base(context)
		{
			_context = context;
		}
	}
}
