using TesteDash.Application.Interfaces;
using TesteDash.Domain.Entities;
using TesteDash.Domain.Interfaces;

namespace TesteDash.Application.Services
{
	public class ProductService : ServiceBase<Product>, IProductService
	{
		private readonly IProductRepository _repository;

		public ProductService(IProductRepository repository) : base(repository)
		{
			_repository = repository;
		}
	}
}
