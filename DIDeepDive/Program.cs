using DIDeepDive.Clients;
using DIDeepDive.Services;

var builder = WebApplication.CreateBuilder(args);

{
    //builder.Services.AddTransient<NumbersService>();
    builder.Services.AddScoped<NumbersService>();
    builder.Services.AddKeyedScoped<INumbersClient, NumbersClient>("one");
    builder.Services.AddKeyedScoped<INumbersClient, NumberThreeClient>("three");
    builder.Services.AddControllers();
}

var app = builder.Build();

{
    app.MapControllers();

    /*
   app.Use(async (httpContext, next) =>
    {
        var client 
        = httpContext.RequestServices
        .GetRequiredService<NumbersClient>();

        client.Increment();

        await next();
    });*/

    app.Run();
}
