// Archivo: ./src/WebApp2XXE00/Program.cs
var builder = WebApplication.CreateBuilder(args);

// Inyectar el servicio de Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Mapear las rutas hacia la carpeta Pages
app.MapRazorPages();

app.Run();