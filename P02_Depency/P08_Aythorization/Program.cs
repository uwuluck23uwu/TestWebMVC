global using P08_Aythorization.Areas.Identity.Data;
global using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P08_Aythorization.Data;
using P08_Aythorization.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AythorizationContextConnection") ?? throw new InvalidOperationException("Connection string 'AythorizationContextConnection' not found.");

builder.Services.AddDbContext<AythorizationContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MyUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 3;
}).AddRoles<IdentityRole>().AddEntityFrameworkStores<AythorizationContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRoleService, RoleService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
