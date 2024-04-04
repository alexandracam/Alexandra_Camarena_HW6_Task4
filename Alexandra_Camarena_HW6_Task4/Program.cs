// Alexandra Camarena 
// MIS 3013 HW 6 Task 4

Order or1;
or1 = new Order();
or1.orderNum = "123";
or1.productName = "Dell Computer";
or1.price = 2000.50;
or1.quantity = 2;

Order or2;
or2 = new Order();
or2.orderNum = "0129";
or2.productName = "Dell Monitors";
or2.price = 499.99;
or2.quantity = 3;

Console.WriteLine("Order 1 information");
string m = string.Format($"Order #: {or1.orderNum}");
Console.WriteLine(m);
m = string.Format($"Product name: {or1.productName}");
Console.WriteLine(m);
m = string.Format($"Price: {or1.price:C2}");
Console.WriteLine(m);
m = string.Format($"Quantity: {or1.quantity}");
Console.WriteLine(m);
double subtotal = or1.price * or1.quantity;
m = string.Format($"Subtotal: {subtotal:C2}");
Console.WriteLine(m);

Console.WriteLine();

Console.WriteLine("Order 2 information");
m = string.Format($"Order #: {or2.orderNum}");
Console.WriteLine(m);
m = string.Format($"Product name: {or2.productName}");
Console.WriteLine(m);
m = string.Format($"Price: {or2.price:C2}");
Console.WriteLine(m);
m = string.Format($"Quantity: {or2.quantity}");
Console.WriteLine(m);
subtotal = or2.price * or2.quantity;
m = string.Format($"Subtotal: {subtotal:C2}");
Console.WriteLine(m);
class Order
{
    public string orderNum;
    public string productName;
    public double price;
    public int quantity;
}