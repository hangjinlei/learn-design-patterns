// See https://aka.ms/new-console-template for more information
public abstract class ProductFactory
{
    public abstract IProduct? CreateProduct();

    public virtual void Create()
    {
        var product = CreateProduct();

        Console.WriteLine($"ProductFactory.Execute() called. Product is {product?.GetType().Name}");

        product?.Execute();
    }
}

public class Product1Factory : ProductFactory
{
    public override IProduct? CreateProduct()
    {
        // do something here
        return new Product1();
    }
}

public class Product2Factory : ProductFactory
{
    public override IProduct? CreateProduct()
    {
        // do something here
        return new Product2();
    }
}
