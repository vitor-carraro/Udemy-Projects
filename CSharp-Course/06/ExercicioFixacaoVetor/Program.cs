using ExercicioFixacaoVetor;


Quarto[] quartos = new Quarto[10];

Console.Write("Quantos quartos serão alugados? ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Aluguel #{0}", i + 1);
    Console.Write("Nome: ");
    string Nome = Console.ReadLine();
    Console.Write("Email: ");
    string Email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    quartos[quarto] = new Quarto { Nome = Nome, Email = Email };

    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Quarto ocupados:");
for (int i = 0; i < 10; i++)
{
    if (quartos[i] != null)
        Console.WriteLine("{0}: {1}", i, quartos[i]);
}








