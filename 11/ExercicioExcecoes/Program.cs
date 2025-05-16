using ExercicioExcecoes.Entities;
using ExercicioExcecoes.Entities.Exceptions;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    if (number < 0)
        throw new DomainException("Tag cannot be negative");

    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    if (string.IsNullOrEmpty(holder))
        throw new DomainException("Holder must have a value");

    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());
    if (balance < 0)
        throw new DomainException("balance cannot be negative");


    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());
    if (withdrawLimit < 0)
        throw new DomainException("Withdraw limit cannot be negative");

    Account account = new(number, holder, balance, withdrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    account.Withdraw(double.Parse(Console.ReadLine()));
    Console.WriteLine("New balance: {0:F2}", account.Balance);

}
catch (DomainException ex) { Console.WriteLine("DomainException error: {0}", ex.Message); }
catch (NoBalanceException ex) { Console.WriteLine("Withdraw error: {0}", ex.Message); }
catch (WithdrawLimitExecption ex) { Console.WriteLine("Withdraw error: {0}", ex.Message); }
catch (Exception ex) { Console.WriteLine("Exception error: {0}", ex.Message); }










