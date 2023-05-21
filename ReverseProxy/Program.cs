var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("YarpConfig"));

var app = builder.Build();


app.UseHttpsRedirection();

app.UseRouting();

app.MapReverseProxy();

app.Run();


