var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}")
//    .WithStaticAssets();

//app.MapControllerRoute(
//    name: "news1",
//    pattern: "News/{controller=Home}/{action=Index}");
//app.MapControllerRoute(
//    name: "news2",
//    pattern: "News{controller}/{action}");

//app.MapControllerRoute(
//    name: "old",
//    pattern: "Shopping/old",
//    defaults: new{controller = "Home", action="Index"});
//app.MapControllerRoute(
//    name: "shop",
//    pattern: "shopping/{action}",
//    defaults: new { controller = "Home" });

//app.MapControllerRoute(
//    name: "MyRoute",
//    pattern: "{controller=Home}/{action=Index}/{id}");

//app.MapControllerRoute(
//    name: "MyRoute1",
//    pattern: "{controller=Home}/{action=Index}/{id?}/{*catchall}");

app.MapControllerRoute(
    name: "intConstraint",
    pattern: "{controller=Home}/{action=Index}/{id:range(5,20)?}");

app.Run();
