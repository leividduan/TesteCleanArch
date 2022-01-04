using AutoMapper;
using TesteDash.Domain.Entities;

namespace TesteDash.Application.DTOs.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Category, CategoryDto>().ReverseMap();
			CreateMap<Product, ProductDto>().ReverseMap();
		}
	}
}
