using ExercicioPolimorfismoHeranca.Entities;

Console.Write("Enter the number of products: ");
int N = int.Parse(Console.ReadLine());

List<Product> products = [new Product("Teste", 10.0)];

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Product #{0} data", i + 1);
    Console.Write("Common, used or imported (c/u/i)? ");
    char typeOfProduct = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    switch (typeOfProduct)
    {
        case 'c':
            products.Add(new Product(name, price));
            break;
        case 'i':
            Console.Write("Customs fee: ");
            double customsFee = double.Parse(Console.ReadLine());
            products.Add(new ImportedProduct(name, price, customsFee));
            break;
        case 'u':
            Console.Write("Manufacture date(DD/MM/YYYY): ");
            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
            products.Add(new UsedProduct(name, price, manufactureDate));
            break;
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}











