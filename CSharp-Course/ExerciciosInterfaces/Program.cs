
using ExerciciosInterfaces.Entities;
using ExerciciosInterfaces.Servicies;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.Parse(Console.ReadLine());

Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());

Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

Contract contract = new(number, contractDate, contractValue, numberOfInstallments);

ContractService contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, numberOfInstallments);

Console.WriteLine("Installments: ");

foreach (var item in contract.Installments)
    Console.WriteLine(item);





