using ExercicioAbstract.Entities;

Console.Write("Enter the number of tax payers: ");
int N = int.Parse(Console.ReadLine());

List<TaxPayer> taxPayers = [];

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Tax payer #{0} data:", i + 1);
    Console.Write("Individual or company (i/c)? ");
    char typeOfPerson = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine());
    switch (typeOfPerson)
    {
        case 'i':
            Console.Write("Health expenditures: ");
            double healthExpenditures = double.Parse(Console.ReadLine());
            taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
            break;
        case 'c':
            Console.Write("Number of employes: ");
            int numberOfEmployes = int.Parse(Console.ReadLine());
            taxPayers.Add(new Company(name, anualIncome, numberOfEmployes));
            break;
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double sum = 0;
foreach (TaxPayer taxPayer in taxPayers)
{
    sum += taxPayer.Tax();
    Console.WriteLine($"{taxPayer.Name}: {taxPayer.Tax():F2}");
}
Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ {0}", sum);















