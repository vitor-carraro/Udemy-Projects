using ExercicioArquivos.Entities;
using System.Globalization;

string sourceFilePath = @"C:\temp\texto1.txt";

try
{
    string[] lines = File.ReadAllLines(sourceFilePath);

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";

    Directory.CreateDirectory(targetFolderPath);

    List<Requests> requests = [];

    foreach (string line in lines)
    {
        string[] values = line.Split(',');
        values[0] = values[0].Trim();
        values[1] = values[1].Trim();
        values[2] = values[2].Trim();

        Requests newRequest = new(values[0], double.Parse(values[1], CultureInfo.InvariantCulture), int.Parse(values[2]));

        requests.Add(newRequest);
    }

    using StreamWriter sr = new(File.OpenWrite(targetFilePath));
    foreach (Requests request in requests)
        sr.WriteLine(request.ToString());

}
catch (IOException ex) { Console.WriteLine("Ocurred an error(IOException): {0}", ex.Message); }
