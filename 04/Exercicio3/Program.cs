using Exercicio3;

Aluno aluno = new();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno:");
for (int i = 0; i < 3; i++)
{
    aluno.Notas[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine(aluno);
