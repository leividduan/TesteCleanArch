using AutoMapper;
using TesteDash.Application.DTOs;
using TesteDash.Domain.Entities;

namespace TesteDash.MVC.ViewModel.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
			CreateMap<ProductDto, ProductViewModel>().ReverseMap();

			CreateMap<Category, CategoryViewModel>().ReverseMap();
			CreateMap<Product, ProductViewModel>().ReverseMap();
		}
	}
}
