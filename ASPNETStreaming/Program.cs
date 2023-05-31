using ASPNETStreaming;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents();
var app = builder.Build();
app.UseHttpsRedirection();
app.MapRazorComponents<MainLayout>();
await app.RunAsync();
