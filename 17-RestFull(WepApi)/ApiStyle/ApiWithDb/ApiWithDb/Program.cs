using ApiWithDb;
using ApiWithDb.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);
//
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnect")));
builder.Services.AddScoped<Response>();

//js'de const url = "https://localhost:7190/" yazdýðýmýzda hata aldýk.
//Aþaðýda yazdýklarýmýz sayesinde bu linkden gelen istekleri bloklama dedik.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          //  "http://www.contoso.com");
                          //Bu html de post olarak gönderdiðimiz verileri okur.
                          policy.AllowAnyOrigin();
                          //Bu js de yazdýðýmýz metotlarý okumaya izin verir.
                          policy.AllowAnyMethod();
                          policy.AllowAnyHeader();
                      });
});
//end
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//
app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
