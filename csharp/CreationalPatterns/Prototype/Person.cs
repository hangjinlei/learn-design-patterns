// See https://aka.ms/new-console-template for more information
public class Person
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Name { get; set; }
    public ID? ID { get; set; }

    public Person? ShallowCopy() => this.MemberwiseClone() as Person;

    public Person DeepCopy()
    {
        var clone = this.MemberwiseClone() as Person;
        clone.ID = new ID(ID.number);
        clone.Name = string.Copy(Name);
        return clone;
    }
}

public class ID
{
    public int number;

    public ID(int number)
    {
        this.number = number;
    }
}
