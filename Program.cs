using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc()
             .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
             .AddDataAnnotationsLocalization();
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseExceptionHandler("/Home/Error");
    //app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    //app.UseExceptionHandler("/Home/Error");

    //app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
var supportedCultures = new List<CultureInfo>()
            {
                new CultureInfo("en"),
                new CultureInfo("nl")
            };
var options = new RequestLocalizationOptions()
{
    DefaultRequestCulture = new RequestCulture("nl"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures,
    RequestCultureProviders = new List<IRequestCultureProvider>()
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                }
};
app.UseRequestLocalization(options);
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
