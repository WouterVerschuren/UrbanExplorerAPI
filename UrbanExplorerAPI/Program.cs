    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.EntityFrameworkCore;

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();


// Set up your database connection string
var connectionString = "Server=tcp:urbanexplorerserver.database.windows.net,1433;Initial Catalog=urbanexplorerdb;Persist Security Info=False;User ID=UrbanExplorer;Password=QRHHpe4y;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

// Add services
builder.Services.AddDbContext<LocationDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
    {
        build.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
    }));

    var app = builder.Build();


        app.UseSwagger();
        app.UseSwaggerUI();

    app.UseCors("corspolicy");

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();


