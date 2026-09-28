var products = new List<Product> { new("Defter", 40m), new("Kalem", 12m) };
var orders = new List<Order> { new(products[0], 2), new(products[1], 3) };
foreach (var order in orders) Console.WriteLine($"{order.Product.Name}: {order.Total:C}");
Console.WriteLine($"Genel toplam: {orders.Sum(order => order.Total):C}");

internal record Product(string Name, decimal Price);
internal record Order(Product Product, int Quantity)
{
    public decimal Total => Product.Price * Quantity;
}
