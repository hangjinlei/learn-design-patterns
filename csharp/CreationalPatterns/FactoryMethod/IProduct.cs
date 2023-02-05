// See https://aka.ms/new-console-template for more information
public interface IProduct
{
    public void Execute();
}

public class Product1 : IProduct
{
    public void Execute()
    {
        Console.WriteLine("Product1.Execute() called.");
    }
}

public class Product2 : IProduct
{
    public void Execute()
    {
        Console.WriteLine("Product2.Execute() called.");
    }
}
