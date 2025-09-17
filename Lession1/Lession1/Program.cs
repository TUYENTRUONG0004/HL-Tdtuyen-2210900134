var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!- truong dinh tuyen -2210900134");

app.Run();
