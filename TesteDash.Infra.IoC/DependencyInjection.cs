using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteDash.Application.DTOs.Mapping;
using TesteDash.Application.Interfaces;
using TesteDash.Application.Services;
using TesteDash.Domain.Interfaces;
using TesteDash.Infra.Data.Context;
using TesteDash.Infra.Data.Repositories;

namespace TesteDash.Infra.IoC
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<DashContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();

			services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IProductService, ProductService>();

			return services;
		}

		public static IServiceCollection AddMapper(this IServiceCollection services, Profile profile)
		{
			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new MappingProfile());
				mc.AddProfile(profile);
			});
			IMapper mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);

			return services;
		}
	}
}
