Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = new StreamReader(File.OpenRead(path)))
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        
        while (!sr.EndOfStream)
        {
            string[] lineVoteRecord = sr.ReadLine().Split(',');
            int numberOfVotes = int.Parse(lineVoteRecord[1]);

            if (!votes.TryAdd(lineVoteRecord[0], numberOfVotes))
            {
                votes[lineVoteRecord[0]] += numberOfVotes;
            }
        }

        foreach(var item in votes)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
catch (IOException e)
{
    Console.WriteLine($"An file error ocurred: {e.Message}");
}
