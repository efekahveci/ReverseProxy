var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/server1", () =>
{
    return "Hello Its Server 1";
});

app.Run();