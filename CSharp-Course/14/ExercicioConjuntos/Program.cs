
HashSet<string> studentsA = new HashSet<string>();

Console.Write("How many students for course A?");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    studentsA.Add(Console.ReadLine());
}

HashSet<string> studentsB = new HashSet<string>();

Console.Write("How many students for course B?");
N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    studentsB.Add(Console.ReadLine());
}

HashSet<string> studentsC = new HashSet<string>();

Console.Write("How many students for course C?");
N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    studentsC.Add(Console.ReadLine());
}

HashSet<string> studentsAll = new HashSet<string>();

studentsAll.UnionWith(studentsA);
studentsAll.UnionWith(studentsB);
studentsAll.UnionWith(studentsC);

Console.WriteLine($"Total students: {studentsAll.Count}");