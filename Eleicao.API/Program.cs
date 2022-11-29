using AutoMapper;
using Eleicao.Aplicacao.Mappers;
using Eleicao.Data.Contexts;
using Eleicao.IoC.App_Start;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EleicaoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Eleicao")), ServiceLifetime.Scoped);

InjectionDependencyCore.ConfigureServices(builder.Services);

IMapper mapperConfig = MapperConfig.RegisterMappers();
builder.Services.AddSingleton(mapperConfig);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
