// See https://aka.ms/new-console-template for more information
public interface IProductFactory
{
    IKeyboard CreateKeyboard();
    IScreen CreateScreen();
}

public class SurfaceFactory : IProductFactory
{
    public IKeyboard CreateKeyboard()
    {
        Console.WriteLine("SurfaceFactory.CreateKeyboard() called.");
        return new SurfaceKeyboard();
    }

    public IScreen CreateScreen()
    {
        Console.WriteLine("SurfaceFactory.CreateScreen() called.");
        return new SurfaceScreen();
    }
}

public class DaGaDaFactory : IProductFactory
{
    public IKeyboard CreateKeyboard()
    {
        Console.WriteLine("DaGaDaFactory.CreateKeyboard() called.");
        return new DaGeDaKeyboard();
    }

    public IScreen CreateScreen()
    {
        Console.WriteLine("DaGaDaFactory.CreateScreen() called.");
        return new DaGeDaScreen();
    }
}
