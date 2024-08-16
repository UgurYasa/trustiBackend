using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICityService, CityManager>();
builder.Services.AddSingleton<ICityDal, EfCityDal>();
builder.Services.AddSingleton<ICustomerService, CustomerManager>();
builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();

builder.Services.AddSingleton<ICoverageService, CoverageManager>();
builder.Services.AddSingleton<ICoverageDal, EfCoverageDal>();

builder.Services.AddSingleton<IPaymentService, PaymentManager>();
builder.Services.AddSingleton<IPaymentDal, EfPaymentDal>();

builder.Services.AddSingleton<IDeclarationService, DeclarationManager>();
builder.Services.AddSingleton<IDeclarationDal, EfDeclarationDal>();

builder.Services.AddSingleton<IDeclarationPersonService, DeclarationPersonManager>();
builder.Services.AddSingleton<IDeclarationPersonDal, EfDeclarationPersonDal>();

builder.Services.AddSingleton<IPolicyService, PolicyManager>();
builder.Services.AddSingleton<IPolicyDal, EfPolicyDal>();

builder.Services.AddSingleton<IPolicyCoverageService, PolicyCoverageManager>();
builder.Services.AddSingleton<IPolicyCoverageDal, EfPolicyCoverageDal>();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
	builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();
app.UseCors("corsapp");
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
