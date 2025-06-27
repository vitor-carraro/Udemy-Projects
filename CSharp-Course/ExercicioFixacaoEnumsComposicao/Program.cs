using ExercicioFixacaoEnumsComposicao.Entities;
using ExercicioFixacaoEnumsComposicao.Entities.Enums;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string clientName = Console.ReadLine();

Console.Write("Email: ");
string clientEmail = Console.ReadLine();

Console.Write("Birth date(DD/MM/YYYY): ");
DateTime birthDateClient = DateTime.Parse(Console.ReadLine());

Client client = new(clientName, clientEmail, birthDateClient);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new(DateTime.Now, orderStatus, client);

Console.Write("How many items to this order? ");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter #{0} item data: ", i + 1);
    Console.Write("Product name: ");
    string productName = Console.ReadLine();

    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine());

    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    order.AddItem(new OrderItem(productQuantity, productPrice, new Product(productName, productPrice)));
}
Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);


