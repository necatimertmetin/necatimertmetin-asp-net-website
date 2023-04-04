var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.AddSupportedCultures(new string[] {"tr-TR","en-US"}).AddSupportedUICultures(new string[] {"tr-TR","en-US"});
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddLocalization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseRequestLocalization();//to support multi languages
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
