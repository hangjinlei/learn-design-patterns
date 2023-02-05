// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var preson1 = new Person();
preson1.Age = 42;
preson1.BirthDate = Convert.ToDateTime("1977-01-01");
preson1.Name = "John Smith";
preson1.ID = new ID(666);

// Perform a shallow copy of person1 and assign it to person2.
var person2 = preson1.ShallowCopy();
// Display values of person1, person2

