var builder = WebApplication.CreateBuilder(args);
// ..
var app = builder.Build();
// ..
app.MapEndpoints(Assembly.GetExecutingAssembly());

app.Run();