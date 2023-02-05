// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
services.AddScoped<IProductFactory, SurfaceFactory>();
services.AddScoped<IProductFactory, DaGaDaFactory>();
var sp = services.BuildServiceProvider();

var factories = sp.GetServices<IProductFactory>();
factories.ToList().ForEach(current =>
{
    var screen = current.CreateScreen();
    var keyboard = current.CreateKeyboard();

    // combine these components together
});
