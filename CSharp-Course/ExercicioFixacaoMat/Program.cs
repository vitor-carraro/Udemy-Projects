
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int[,] Mat = new int[M, N];

for (int i = 0; i < M; i++)
{
    string[] Values = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        Mat[i, j] = int.Parse(Values[j]);
    }
}

int X = int.Parse(Console.ReadLine());

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (X == Mat[i, j])
        {
            Console.WriteLine("Position {0},{1}", i, j);
            if (j - 1 >= 0)
                Console.WriteLine("Left: {0}", Mat[i, j - 1]);
            if (j + 1 < N)
                Console.WriteLine("Right: {0}", Mat[i, j + 1]);
            if (i + 1 < M)
                Console.WriteLine("Down: {0}", Mat[i + 1, j]);
            if (i - 1 >= 0)
                Console.WriteLine("Up: {0}", Mat[i - 1, j]);
        }
    }
}









