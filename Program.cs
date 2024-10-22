var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello AWS AppRunner !!");

app.MapGet("/api/coffee", () => new List<dynamic> {
    new { CoffeeId = "cappucino", CoffeeName = "Cappucino" },
    new { CoffeeId = "latte", CoffeeName = "Latte" },
    new { CoffeeId = "mocha", CoffeeName = "Mocha" },
    new { CoffeeId = "americano", CoffeeName = "Americano" },
    new { CoffeeId = "macchiato", CoffeeName = "Macchiato" },
    new { CoffeeId = "frappe", CoffeeName = "Frappe" },
    new { CoffeeId = "corretto", CoffeeName = "Corretto" },
    new { CoffeeId = "affogato", CoffeeName = "Affogato" },
    new { CoffeeId = "filtercoffee", CoffeeName = "Filter Coffee" },
});

app.Run();

