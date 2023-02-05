// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var builder = new CarBuilder();
var director = new CarDirector(builder);
var minimalCar = director.BuildMinimalCar();
minimalCar.ShowComponents();