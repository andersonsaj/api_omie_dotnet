using IntegracaoOmie;
using IntegracaoOmie.Rest;
using IntegracaoOmie.Rest.Interface;
using IntegracaoOmie.Services;
using IntegracaoOmie.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRouting(option => option.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddScoped<IClienteRest, ClienteRest>();
builder.Services.AddApplication(builder.Configuration);

//builder.Services.AddScoped(provider => new AutoMapper.MapperConfiguration(config =>
//{
//    config.AddProfile(new AutoMapperConfiguracao());
//}).CreateMapper());

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
