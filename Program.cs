using Generics.NET;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/products", (Body body) =>
{
    List<Product> products = [
        new() { Name = "Shoe", Price = 45.26M },
        new() { Name = "Jacket", Price = 30.1M },
        new() { Name = "T-shirt", Price = 20.4M }
        ];

    //foreach (var item in products)
    //{
    //    var productFound = Helper<Product>.Matches(item, body.Name);

    //    if (productFound) return Results.Ok(item);
    //}

    var product = products.Find(x => x.Name.Equals(body.Name));

    return product is null ? Results.NotFound() : Results.Ok(product);
});

app.MapPost("/order", (Body body) =>
{
    List<Order> orders = [
        new() { Name = "Order1", CreatedDate = DateTime.Now },
        new() { Name = "Order2", CreatedDate = DateTime.MinValue },
        new() { Name = "Order3", CreatedDate = DateTime.MaxValue }
        ];

    //foreach (var item in orders)
    //{
    //    var orderFound = Helper<Order>.Matches(item, body.Name);

    //    if (orderFound) return Results.Ok(item);
    //}

    var order = orders.Find(x => x.Name.Equals(body.Name));

    return order is null ? Results.NotFound() : Results.Ok(order);

    //return Results.NotFound();
});

app.Run();
