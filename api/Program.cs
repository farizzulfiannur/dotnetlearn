using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext> (Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/test-stock", () =>
{
    var stock = new Stock();
    stock.Comments.Add (new Comment
    {
        Id = 0,
        Title = "Dasar Pemrograman",
        Content = "Ini merupakan Content Pertama Dasar Pemrograman"
    });
    stock.Comments.Add (new Comment
    {
        Id = 1,
        Title = "Dasar Pemrograman",
        Content = "Ini merupakan Content Kedua Dasar Pemrograman"
    });

    return stock.Comments;
    // return new
    // {
    //     CommentTitle1 = stock.Comments[0].Title
    // };
});

app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
