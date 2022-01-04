using TesteDash.Infra.IoC;
using TesteDash.MVC.ViewModel.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddInfra(builder.Configuration);
builder.Services.AddMapper(new MappingProfile());

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
