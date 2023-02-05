// See https://aka.ms/new-console-template for more information
public interface IMiddleware
{
    public IMiddleware SetNext(IMiddleware next);
    public object Run();
    public object Run(object request);
    public object Run(object request, IMiddleware next);
}

public abstract class AbstractMiddleware : IMiddleware
{
    private IMiddleware _next;
    protected object _request;

    public AbstractMiddleware()
    {

    }

    public AbstractMiddleware(object request)
    {
        _request = request;
    }

    public virtual object Run() => _next?.Run(_request) ?? default!;

    public virtual object Run(object request) => _next?.Run(request) ?? default!;

    public virtual object Run(object request, IMiddleware next)
    {
        this._next = next;
        return this._next?.Run(request);
    }

    public virtual IMiddleware SetNext(IMiddleware next)
    {
        this._next = next;
        return this;
    }
}

public class PipelineMiddleware : AbstractMiddleware
{
    public PipelineMiddleware(object request) : base(request)
    {
    }

    public override object Run()
    {
        Console.WriteLine(_request as string);
        return base.Run();
    }
}
