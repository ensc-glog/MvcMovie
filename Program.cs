using MvcMovie.Data;
using MvcMovie.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Attach an EF Core database context to each query
builder.Services.AddDbContext<MvcMovieContext>();

var app = builder.Build();

// Seed data into DB
SeedData.Init();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

// Redirects HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Enables static files, such as HTML, CSS, images, and JavaScript to be served.
app.UseStaticFiles();

// Adds route matching.
app.UseRouting();

// Authorizes a user to access secure resources (not mandatory here).
app.UseAuthorization();

// Define routing strategy.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
