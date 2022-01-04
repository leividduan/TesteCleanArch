using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TesteDash.Application.Interfaces;
using TesteDash.Domain.Entities;
using TesteDash.MVC.ViewModel;

namespace TesteDash.MVC.Controllers
{
	public class CategoryController : Controller
	{
		private readonly IMapper _mapper;
		private readonly ICategoryService _service;
		public CategoryController(IMapper mapper, ICategoryService service)
		{
			_mapper = mapper;
			_service = service;
		}
		public IActionResult Index()
		{
			var categories = _service.Get();
			var list = _mapper.Map<IEnumerable<CategoryViewModel>>(categories);
			return View(list);
		}

		[HttpPost]
		public IActionResult Create()
		{
			var category = new Category { Name = $"teste{Guid.NewGuid().ToString().Substring(0, 5)}" };
			_service.Add(category);
			_service.Save();

			return Json(new { });
		}
	}
}
