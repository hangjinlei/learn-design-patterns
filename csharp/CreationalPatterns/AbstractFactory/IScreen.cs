// See https://aka.ms/new-console-template for more information
public interface IScreen
{
}

public interface ITouchScreen : IScreen
{
    public void Touch();
}


public class SurfaceScreen : ITouchScreen
{
    public void Touch()
    {
        Console.WriteLine("SurfaceScreen.Touch() called.");
    }
}

public class DaGeDaScreen : IScreen
{
}