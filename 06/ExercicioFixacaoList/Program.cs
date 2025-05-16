using ExercicioFixacaoList;

Console.Write("How many employees be registered? ");
int N = int.Parse(Console.ReadLine());

List<Employee> employees = new();

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Employee #{0}", i + 1);
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    if (employees.Find(x => x.Id == id) == null)
    {
        employees.Add(new Employee(id, name, salary));
    }
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase: ");
Employee? employeeIncreaseSalary = employees.Find(x => x.Id == int.Parse(Console.ReadLine()));

if (employeeIncreaseSalary != null)
{
    Console.Write("Enter the percentage: ");
    employeeIncreaseSalary.IncreaseSalary(double.Parse(Console.ReadLine()));
}
else
{
    Console.WriteLine("This id does not exist!");
}
Console.WriteLine();

Console.WriteLine("Updated list of employees:");
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}










