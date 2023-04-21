using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Data.Entities;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 builder.Configuration.AddJsonFile("./appsettings.json", optional: true, reloadOnChange: true);

var temp = builder.Configuration.GetConnectionString("MyWorldDBConnection");
var config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false)
        .Build();
var data = config.GetSection("ConnectionString:MyWorldDbContext").Value;
var data1 = config.GetSection("ConnectionString:MyTestDBConnection").Value;
//var noOfDb =Convert.ToInt32(config.GetSection("NoOfDBs").Value);
//List<string> list = new List<string>();
//var test = config.GetRequiredSection("ConnectionString");

//    for (int i=1;i<=noOfDb;i++)
//{

//    var data = config.GetSection("ConnectionString:{i}").Value;

//    builder.Services.AddDbContext<MyWorldDbContext>(options =>
//    {
//        options.UseSqlServer(data);
//    });
//}
builder.Services.AddDbContext<MyWorldDbContext>(options =>
{
    options.UseSqlServer(data);
});
builder.Services.AddDbContext<MyTestDBContext>(options =>
{
    options.UseSqlServer(data1);
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
