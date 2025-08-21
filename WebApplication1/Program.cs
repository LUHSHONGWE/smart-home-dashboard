var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Serves index.html by default
app.UseStaticFiles();  // Enables serving static files from wwwroot

app.Run();