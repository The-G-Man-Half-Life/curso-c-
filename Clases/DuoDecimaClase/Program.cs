var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AplicationDBContext>(options ->
options.UseMySql(
    builder.Configuration.GetConnectionsString("AplicationDBContext"),
    ServerVersion.Parse("8.0.20-mysql")))

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
