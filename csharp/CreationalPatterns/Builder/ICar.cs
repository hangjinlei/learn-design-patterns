// See https://aka.ms/new-console-template for more information
public interface ICar
{
    public void Add(string component);
    public void ShowComponents();
}

public class Car : ICar
{
    private IList<string> Components { get; set; } = new List<string>();

    public void Add(string component)
    {
        if (!Components.Contains(component))
        {
            Components.Add(component);
        }
    }

    public void ShowComponents() => Components.ToList().ForEach(Console.WriteLine);
}

// Add more types of cars here
