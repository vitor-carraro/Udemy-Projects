using Exercicio2;

Funcionario funcionario = new();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine("\nFuncionário: {0}", funcionario);

Console.Write("\nDigite a porcentagem para aumentar o salário: ");
funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

Console.WriteLine("\nDados atualizados: {0}", funcionario);


