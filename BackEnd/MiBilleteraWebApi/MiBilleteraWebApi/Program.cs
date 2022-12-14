using Negocio;
using System.Text.Json.Serialization;

var MyAllowSpecificOringins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);


//Cambiar el localhost segun el puerto donde corre la api
builder.Services.AddCors(options => {
    options.AddPolicy(name: MyAllowSpecificOringins, policy =>
    {
        policy.WithOrigins("*");
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(MyAllowSpecificOringins);

app.MapControllers();

app.Run();
