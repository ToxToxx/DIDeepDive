using DIDeepDive.Clients;
using DIDeepDive.Services;

var builder = WebApplication.CreateBuilder(args);

{
    //builder.Services.AddTransient<NumbersService>();
    builder.Services.AddScoped<NumbersService>();

    ServiceDescriptor serviceDescriptor = new(
        serviceType: typeof(INumbersClient),
        implementationType: typeof(NumbersClient),
        lifetime: ServiceLifetime.Singleton);

    builder.Services.Add(serviceDescriptor);

    builder.Services.AddScoped<INumbersClient, NumbersClient>();
    builder.Services.AddScoped<INumbersClient, NumberThreeClient>();
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
