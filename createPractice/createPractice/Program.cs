using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using createPractice;
using createPractice.AOP;
using createPractice.Repositories;
using createPractice.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IWeatherForecastService, WeatherForecastService>();
//builder.Services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterType<WeatherForecastService>().As<IWeatherForecastService>().EnableInterfaceInterceptors();
    containerBuilder.RegisterType<WeatherForecastRepository>().As<IWeatherForecastRepository>().EnableInterfaceInterceptors();
    containerBuilder.RegisterType<LoggingInterceptor>();

    //var controllerBaseType = typeof(ControllerBase);
    //containerBuilder.RegisterAssemblyTypes(typeof(Program).Assembly)
    //   .Where(t => controllerBaseType.IsAssignableFrom(t) && t != controllerBaseType)
    //   .PropertiesAutowired(new LogInterceptor());
});

Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
