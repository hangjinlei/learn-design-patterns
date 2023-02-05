// See https://aka.ms/new-console-template for more information
public interface ICarBuilder
{
    public ICarBuilder Clear();

    public ICarBuilder AddEngine(string engine);

    public ICarBuilder AddWheels(string wheels);

    public ICarBuilder AddBody(string body);

    public ICarBuilder AddInterior(string interior);

    public ICarBuilder AddColor(string color);

    public ICarBuilder AddTransmission(string transmission);

    public ICarBuilder AddAirConditioning(string airConditioning);

    public ICarBuilder AddGPS(string gps);

    public ICarBuilder AddSunroof(string sunroof);

    public ICarBuilder AddRoofRack(string roofRack);

    public ICarBuilder AddSpoiler(string spoiler);

    public ICarBuilder AddTintedWindows(string tintedWindows);

    public ICarBuilder AddAlarm(string alarm);

    public ICar Build();
}

public class CarBuilder : ICarBuilder
{
    private ICar car;

    public ICar Build() => car;

    public ICarBuilder Clear()
    {
        car = new Car();
        return this;
    }

    public ICarBuilder AddAirConditioning(string airConditioning)
    {
        car.Add(airConditioning);
        return this;
    }

    public ICarBuilder AddAlarm(string alarm)
    {
        car.Add(alarm);
        return this;
    }

    public ICarBuilder AddBody(string body)
    {
        car.Add(body);
        return this;
    }

    public ICarBuilder AddColor(string color)
    {
        car.Add(color);
        return this;
    }

    public ICarBuilder AddEngine(string engine)
    {
        car.Add(engine);
        return this;
    }

    public ICarBuilder AddGPS(string gps)
    {
        car.Add(gps);
        return this;
    }

    public ICarBuilder AddInterior(string interior)
    {
        car.Add(interior);
        return this;
    }

    public ICarBuilder AddRoofRack(string roofRack)
    {
        car.Add(roofRack);
        return this;
    }

    public ICarBuilder AddSpoiler(string spoiler)
    {
        car.Add(spoiler);
        return this;
    }

    public ICarBuilder AddSunroof(string sunroof)
    {
        car.Add(sunroof);
        return this;
    }

    public ICarBuilder AddTintedWindows(string tintedWindows)
    {
        car.Add(tintedWindows);
        return this;
    }

    public ICarBuilder AddTransmission(string transmission)
    {
        car.Add(transmission);
        return this;
    }

    public ICarBuilder AddWheels(string wheels)
    {
        car.Add(wheels);
        return this;
    }
}
