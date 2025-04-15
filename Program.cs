using BorsaHisseSite.Services;

var builder = WebApplication.CreateBuilder(args);

// DB Context Ayarı
builder.Services.AddDbContext<BorsaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<FinnhubService>();



// Add HttpClient and HisseService
builder.Services.AddHttpClient<HisseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
