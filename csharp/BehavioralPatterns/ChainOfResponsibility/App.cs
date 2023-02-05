// See https://aka.ms/new-console-template for more information
public class App
{
    private IList<IMiddleware> _middlewares;

    public App()
    {
        _middlewares = new List<IMiddleware>();
    }

    public App Use(IMiddleware middleware)
    {
        _middlewares.Add(middleware);
        return this;
    }

    public void Run()
    {
        _middlewares.ToList().ForEach(middleware => middleware.Run());
    }
}
