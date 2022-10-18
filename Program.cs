using LapShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
////builder.Services.AddIdentity<IdentityUser, IdentityRole>(opeation =>
////opeation.Password.RequiredLength = 8

////).AddEntityFrameworkStores<LapShopContext> ();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();   
var app = builder.Build();

app.UseHttpsRedirection();  

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
     name: "area",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=index}/{id?}");

    endpoints.MapControllerRoute(
       name: "Order",
       pattern: "{controller=OrderController}/{action=Cart}/{id?}");








});
app.Run();
