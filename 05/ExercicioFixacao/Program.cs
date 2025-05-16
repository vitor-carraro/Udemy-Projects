using ExercicioFixacao;

Console.Write("Entre o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char simNaoSaldoInicial = char.Parse(Console.ReadLine());

ContaBancaria conta;
if (simNaoSaldoInicial == 's')
{
    Console.Write("Entre o valor de deposito inicial: ");
    double valorInicial = double.Parse(Console.ReadLine());
    conta = new ContaBancaria(numeroConta, nomeTitular, valorInicial);
}
else
    conta = new ContaBancaria(numeroConta, nomeTitular);

Console.WriteLine("\nDados da conta:");
Console.WriteLine("{0}\n", conta);

Console.Write("Entre um valor para depósito: ");
conta.Deposito(double.Parse(Console.ReadLine()));
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine("{0}\n", conta);

Console.Write("Entre um valor para saque: ");
conta.Saque(double.Parse(Console.ReadLine()));
Console.WriteLine("Dados da conta atualizados:");
Console.Write(conta);