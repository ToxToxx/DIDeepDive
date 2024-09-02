using DIDeepDive.Clients;
using DIDeepDive.Services;

var builder = WebApplication.CreateBuilder(args);

{
    //builder.Services.AddTransient<NumbersService>();
    builder.Services.AddSingleton<NumbersService>();
    builder.Services.AddTransient<NumbersClient>();
    builder.Services.AddControllers();
}

var app = builder.Build();

{
    app.MapControllers();
    app.Run();
}
