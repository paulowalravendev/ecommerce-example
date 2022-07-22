var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers().Services
    .AddInfrastructure(
        allowOrigin: builder.Configuration.GetSection(AppSettingsConstants.AllowOriginSection).Value, 
        connectionString: builder.Configuration.GetConnectionString("DefaultConnection"))
    .AddApplication()
    .AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.UseHttpsRedirection()
    .UseInfrastructure(
        showSwagger: app.Environment.IsDevelopment(), 
        healthCheckPath: "/healthcheck")
    .UseAuthorization();

app.MapControllers();

app.Run();