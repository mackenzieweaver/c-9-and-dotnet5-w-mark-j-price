using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;
using static System.Console;
using NorthwindService.Repositories;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Http; // GetEndpoint() extension method
using Microsoft.AspNetCore.Routing; // RouteEndpoint

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        builder =>
        {
            builder.WithMethods("GET", "POST", "PUT", "DELETE");
            builder.WithOrigins("https://localhost:5002");
        });
});

// Add services to the container.
string databasePath = Path.Combine("..", "Northwind.db");
builder.Services.AddDbContext<Northwind>(options =>
    options.UseSqlite($"Data Source={databasePath}"));

builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters:");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        var mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter == null)
        {
            WriteLine($" {formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes
        {
            WriteLine(" {0}, Media types: {1}",
            arg0: mediaFormatter.GetType().Name,
            arg1: string.Join(", ",
            mediaFormatter.SupportedMediaTypes));
        }
    }
})
.AddXmlDataContractSerializerFormatters()
.AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddHealthChecks().AddDbContextCheck<Northwind>();

var app = builder.Build();

app.UseMiddleware<SecurityHeaders>();

// app.Use(next => (context) =>
//     {
//         var endpoint = context.GetEndpoint();
//         if (endpoint != null)
//         {
//             WriteLine("*** Name: {0}; Route: {1}; Metadata: {2}",
//             arg0: endpoint.DisplayName,
//             arg1: (endpoint as RouteEndpoint)?.RoutePattern,
//             arg2: string.Join(", ", endpoint.Metadata));
//         }
//         // pass context to next middleware in pipeline
//         return next(context);
//     }
// );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Northwind Service API Version 1");
        c.SupportedSubmitMethods(new[]
        {
            SubmitMethod.Get,
            SubmitMethod.Post,
            SubmitMethod.Put,
            SubmitMethod.Delete
        });
    });
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseHealthChecks(path: "/howdoyoufeel");

app.Run();
