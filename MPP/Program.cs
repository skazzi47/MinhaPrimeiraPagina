var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/index.html", async context =>
{
await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run();