using Půjčovna.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Půjčovna.Controllers;
using Půjčovna.Data.Shared;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Půjčovna.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthenticationCore();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorContextMenu();
builder.Services.AddLocalization();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomerService, CustomerController>();
builder.Services.AddScoped<ContactPersonService, ContactPersonController>();
builder.Services.AddScoped<Borrow_thingsService, Borrow_thingsController>();
builder.Services.AddScoped<CategoriesService, CategoriesController>();
builder.Services.AddScoped<ThingsToBorrowService, ThingsToBorrowController>();
builder.Services.AddScoped<BorrowsService, BorrowsController>();
builder.Services.AddScoped<EmployeeService, EmployeeController>();
builder.Services.AddSingleton<MyCustomerContainer>();
builder.Services.AddSingleton<MyEmployeeContainer>();
builder.Services.AddSingleton<MyThingContainer>();
builder.Services.AddSingleton<MyBorrowContainer>();
builder.Services.AddDbContext<BorrowDB>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
var localizeOptions = new RequestLocalizationOptions()
				.SetDefaultCulture("en-US")
				.AddSupportedCultures("en-US", "cs-CZ")
				.AddSupportedUICultures("en-US", "cs-CZ");

app.UseRequestLocalization(localizeOptions);
app.UseHttpsRedirection();

app.UseStaticFiles();


app.UseRouting();
app.MapControllers();
app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();