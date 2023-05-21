var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();


app.MapGet("/server2", context =>
{
    var headers = context.Request.Headers;

    var userAgent = headers["User-Agent"];

    return context.Response.WriteAsync($"User-Agent: {userAgent}");
});

app.Run();
