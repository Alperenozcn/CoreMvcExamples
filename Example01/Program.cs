var builder = WebApplication.CreateBuilder(args);
//kaydediyoz (ekliyoruz)

builder.Services.AddControllersWithViews();


var app = builder.Build();
//kullanýyoz

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}", defaults: new { controller = "Home", action = "Index" });
});



app.Run();

