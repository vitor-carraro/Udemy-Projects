using ExercicioLambda.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
string filePath = Console.ReadLine();

Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

using (StreamReader sr = File.OpenText(filePath))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        double employeeSalary = double.Parse(fields[2], CultureInfo.InvariantCulture);

        employees.Add(new Employee(fields[0], fields[1], employeeSalary));
    }
}

Console.WriteLine($"Email of people whose salary is more than {salary}:");
employees.Where(e => e.Salary > salary)
         .Select(e => e.Email)
         .OrderBy(e => e)
         .ToList()
         .ForEach(Console.WriteLine);

Console.Write("Sum of salary of people whose name starts with 'M': ");
var sum = employees.Where(e => e.Name.StartsWith('M'))
         .Select(e => e.Salary)
         .DefaultIfEmpty(0.0)
         .Sum()
         .ToString("F2");
Console.WriteLine(sum);











