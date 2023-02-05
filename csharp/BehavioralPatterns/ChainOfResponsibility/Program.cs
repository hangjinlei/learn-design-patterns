// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var request = """
    {
        ""name"": ""John"",
        ""age"": 30,
        ""cars"": [
            ""Ford"",
            ""BMW"",
            ""Fiat""
        ]
    }
    """;

var app = new App();
app.Use(new PipelineMiddleware(request));
app.Run();
