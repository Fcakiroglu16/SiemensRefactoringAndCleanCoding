using App.API.AdapterDesignPattern;
using Application;
using Application.Decorators;
using Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IImageProcess>(sp =>
{
    var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();

    var tenantId= httpContextAccessor.HttpContext.Request.Headers.TryGetValue("tenantId",out StringValues tenantType)
    {

    }


    if (httpContextAccessor.HttpContext.Request.Query.ContainsKey("x"))
    {
        return new ImageProcess();
    }

    return new LazziyaImageProcessAdapter();
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddMemoryCache();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IProductService>(sp =>
{
    var productRepository = sp.GetService<IProductRepository>();
    var memoryCaching = sp.GetRequiredService<IMemoryCache>();

    var contextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
    var productService = new ProductService(productRepository!);

    if (contextAccessor.HttpContext.Request.Query.ContainsKey("logging"))
    {
        var loggingDecorator = new LoggingDecorator(productService);
        return loggingDecorator;
    }

    if (contextAccessor.HttpContext.Request.Query.ContainsKey("caching"))
    {
        var cachingDecorator = new CachingDecorator(productService, memoryCaching);
        return cachingDecorator;
    }


    var cachingDecorator2 = new CachingDecorator(productService, memoryCaching);
    var loggingDecorator2 = new LoggingDecorator(cachingDecorator2);


    return loggingDecorator2;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();