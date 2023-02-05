// See https://aka.ms/new-console-template for more information
public class CarDirector
{
    private ICarBuilder builder;

    public CarDirector(ICarBuilder builder)
    {
        this.builder = builder;
    }

    public ICar BuildMinimalCar()
    {
        return builder.Clear()
            .AddEngine("V8")
            .AddWheels("4")
            .AddBody("Sedan")
            .AddInterior("Leather")
            .AddColor("Red")
            .AddTransmission("Automatic")
            .Build();
    }

    public ICar BuildFullCar()
    {
        return builder.Clear()
            .AddEngine("V8")
            .AddWheels("4")
            .AddBody("Sedan")
            .AddInterior("Leather")
            .AddColor("Red")
            .AddTransmission("Automatic")
            .AddAirConditioning("Air Conditioning")
            .AddGPS("GPS")
            .AddSunroof("Sunroof")
            .AddRoofRack("Roof Rack")
            .AddSpoiler("Spoiler")
            .AddTintedWindows("Tinted Windows")
            .AddAlarm("Alarm")
            .Build();
    }
}